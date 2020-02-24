USE [Alver]
GO

/****** Object:  View [dbo].[V_CLIENTS]    Script Date: 2/24/2020 10:20:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






/*TRANS.CurrencyId*/
CREATE VIEW [dbo].[V_CLIENTS]
AS
SELECT		ISNULL(AccountId,0) AS AccountId,
			(SELECT    Fullname
			FROM         dbo.Account AS AI
			WHERE      (Id = TRANS.AccountId)) AS Account,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 1))) AS USDAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 2)) ) AS SYPAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 3)) ) AS TLAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 4)) ) AS EUROAmount,
			(SELECT    (SELECT    SUM(Amount)
			FROM          dbo.[Transaction] AS T
			WHERE      (AccountId = TRANS.AccountId) AND (CurrencyId = 5)) ) AS SARAmount
			,
			(SELECT
			(
				(SELECT    (SELECT    SUM(Amount)	FROM  dbo.[Transaction] AS T	WHERE  (AccountId = TRANS.AccountId) AND (CurrencyId = 1)))
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 2)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=2 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 3)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=3 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 4)))
					*
					(SELECT (SELECT TOP 1 BUL.RATE FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=4 ORDER BY BUL.RateDate DESC))
				)
				+
				(
					(SELECT (SELECT  SUM(Amount) FROM dbo.[Transaction] AS T WHERE (AccountId = TRANS.AccountId) AND (CurrencyId = 5)))
					*
					(SELECT (SELECT TOP 1 BUL.ReversedRate FROM CurrencyBulletin BUL WHERE BUL.CurrencyId=5 ORDER BY BUL.RateDate DESC))
				)
			)
			) AS GRAND
FROM         dbo.[Transaction] AS TRANS
GROUP BY AccountId


GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TRANS"
            Begin Extent = 
               Top = 11
               Left = 501
               Bottom = 280
               Right = 695
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2532
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CLIENTS'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'V_CLIENTS'
GO


