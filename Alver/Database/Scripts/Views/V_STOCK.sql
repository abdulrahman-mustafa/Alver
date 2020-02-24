USE [Alver]
GO

/****** Object:  View [dbo].[V_CLIENTS]    Script Date: 2/24/2020 9:43:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_STOCK]
AS
SELECT		ISNULL(ItemId,0) AS 'رقم_المادة',

			(SELECT    AI.ItemName
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'اسم_المادة',

			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[ItemTransaction] AS T
			WHERE      (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1))) AS 'عدد_الكروزات_المتوفرة',

			(SELECT    AI.CurrencyId
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'العملة',

			(SELECT    AI.PurchasePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_شراء_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'تكلفة الشراء',

			(SELECT    AI.SalePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId)) AS 'سعر_مبيع_الواحدة',

			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			) AS 'مجموع المبيعات',

			(SELECT
			(
				(SELECT    AI.SalePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId))
				-
				(SELECT    AI.PurchasePrice
			FROM         dbo.Item AS AI
			WHERE      (AI.Id = TRANS.ItemId))
			)
			) AS 'هامش_الربح_في_القطعة_الواحدة',

			(SELECT
			(
				(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.SalePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			-
			(SELECT
			(
				(SELECT (SELECT  SUM(Amount) FROM dbo.[ItemTransaction] AS T WHERE (T.ItemId = TRANS.ItemId) AND (T.UnitId = 1)))
				*
				(SELECT    AI.PurchasePrice	FROM  dbo.Item AS AI	WHERE   (AI.Id = TRANS.ItemId))
			)
			)
			)
			) AS 'الربح_المتوقع'

FROM         dbo.[ItemTransaction] AS TRANS
GROUP BY TRANS.ItemId


GO
