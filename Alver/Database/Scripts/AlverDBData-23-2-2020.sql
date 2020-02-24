USE [Alver]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'Owner', N'Database Owner', N'f70d9626-c079-42b7-b23a-929f1d37185e', 1, N'OWNER', CAST(N'2019-08-09T15:54:10.550' AS DateTime), 1)
INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'المدير العام', NULL, N'378ac68c-7524-42c7-bca6-9dd0999e7f7a', 0, NULL, CAST(N'2019-08-09T15:55:56.767' AS DateTime), 1)
INSERT [dbo].[Role] ([Id], [RoleTitle], [Declaration], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'مستخدم', NULL, N'9f8c398a-edd7-4897-a908-eb251fa62647', 0, NULL, CAST(N'2019-08-09T16:00:29.013' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, 1, N'ADMIN', N'5111990@bdo', N'ADMIN', 0, 1, 0, N'ADMINISTRATOR', NULL, CAST(N'2019-10-20T01:49:22.697' AS DateTime), N'ccfab2c0-f13d-4e2d-a893-5ff2e11fb64f', 1, NULL, CAST(N'2019-08-16T16:15:35.233' AS DateTime), 1)
INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, 2, N'المدير', N'12345', N'المدير', 0, 1, 0, NULL, NULL, CAST(N'2020-02-19T22:08:44.390' AS DateTime), N'c8f343da-cdab-43a3-b2a3-e98208315184', 0, NULL, CAST(N'2019-08-16T16:15:35.233' AS DateTime), 1)
INSERT [dbo].[User] ([Id], [RoleId], [UserName], [Password], [FullName], [LoginAttempts], [Locked], [Deactivated], [Declaration], [CD], [LLD], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, 2, N'0', N'0', N'حنان', NULL, NULL, NULL, N'', CAST(N'2020-02-19T22:09:00.303' AS DateTime), CAST(N'2020-02-20T11:13:07.723' AS DateTime), N'0d131e4d-a561-417b-aa82-eb7a86865c21', 0, N'', CAST(N'2020-02-19T22:09:00.303' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[Currency] ON 

INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'دولار امريكي', N'$', N'USD', 1, 1.0000, NULL, 1, N'76c731da-72b4-42a8-a2fe-c4f7d4966077', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'ليرة سورية', N'ل.س', N'SYP', 0, NULL, NULL, 1, N'07617da8-e2a3-4138-a18c-9e3802144e5c', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'ليرة تركية', N'₺', N'TL', 0, NULL, NULL, 1, N'de6751ff-0b2d-4b09-b920-475b2066ce5e', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (4, N'يورو', N'€', N'EUR', 0, NULL, NULL, 1, N'9e6aa285-8b15-4b46-af79-499c2d72ef77', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
INSERT [dbo].[Currency] ([Id], [CurrencyName], [CurrencySymbol], [CurrencyCode], [BaseCurrency], [ExchangeRate], [Notes], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (5, N'ريال سعودي', N'SR', N'SAR', 0, NULL, NULL, 1, N'ebade2aa-c234-4292-b878-d8b356a92ac4', 0, NULL, CAST(N'2019-11-09T22:18:47.693' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Currency] OFF
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([Id], [Title], [Symbol], [IsDefault], [Declaration], [UserId], [Hidden], [Flag], [GUID], [LUD], [PROTECTED]) VALUES (1, N'كروز', N'CRZ', NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Unit] OFF
SET IDENTITY_INSERT [dbo].[ItemCategory] ON 

INSERT [dbo].[ItemCategory] ([Id], [Title], [Declaration], [UserId], [Hidden], [Flag], [GUID], [LUD], [PROTECTED]) VALUES (1, N'دخان وطني', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ItemCategory] ([Id], [Title], [Declaration], [UserId], [Hidden], [Flag], [GUID], [LUD], [PROTECTED]) VALUES (2, N'دخان اجنبي', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ItemCategory] OFF
SET IDENTITY_INSERT [dbo].[Fund] ON 

INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (1, N'صندوق الدولار', 1, 0.0000, N'لنا', N'', 1, N'cdc98385-aade-428c-a540-e1446d51ac12', 0, N'', CAST(N'2019-08-27T03:53:18.293' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (2, N'صندوق السوري', 2, 0.0000, N'لنا', N'', 1, N'd3fedfd9-6997-4b66-9896-bd8194edfadc', 0, N'', CAST(N'2019-08-27T03:53:18.363' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (3, N'صندوق التركي', 3, 0.0000, N'لنا', N'', 1, N'b83fa457-60ce-4df6-b7be-e4f1a32cbbc5', 0, N'', CAST(N'2019-08-27T03:53:18.367' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (4, N'صندوق اليورو', 4, 0.0000, N'لنا', N'', 1, N'7e3ce3f9-c047-4069-8566-22177bed12b9', 0, N'', CAST(N'2019-08-27T03:53:18.370' AS DateTime), 1)
INSERT [dbo].[Fund] ([Id], [FundTitle], [CurrencyId], [Balance], [BalanceDirection], [Declaration], [UserId], [GUID], [Hidden], [Flag], [LUD], [PROTECTED]) VALUES (5, N'صندوق السعودي', 5, 0.0000, N'لنا', N'', 1, N'be17e9b8-e71b-4948-8b40-f4317b6b3497', 0, N'', CAST(N'2019-08-27T03:54:44.983' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Fund] OFF
