USE [iemt_pdt_es01_development]
GO

/****** Object:  Table [dbo].[ENGINE_LIST]    Script Date: 9/21/2015 11:00:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BALL_ENGINE_LIST](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ENGINE_TYPE] [char](4) NOT NULL,
	[ENGINE_NO] [char](6) NOT NULL,
	[ENGINE_ASM_NO] [char](10) NOT NULL,
	[BOOK] [char](2) NOT NULL,
	[YEAR] [varchar](4) NOT NULL,
	[MODEL_CODE] [char](8) NOT NULL,
	[LOT_NO] [varchar](4) NOT NULL,
	[UNIT_NO] [varchar](2) NOT NULL,
	[AT_MT] [char](2) NOT NULL,
	[EMISSION] [char](2) NOT NULL,
	[INJ_MODEL_CODE] [char](2) NOT NULL,
	[SPARE_001] [char](2) NOT NULL,
	[SPARE_002] [char](2) NOT NULL,
	[SPARE_003] [char](2) NOT NULL,
	[SPARE_004] [char](2) NOT NULL,
	[SPARE_005] [char](2) NOT NULL,
	[SPARE_006] [char](2) NOT NULL,
	[SPARE_007] [char](2) NOT NULL,
	[SPARE_008] [char](2) NOT NULL,
	[SPARE_009] [char](2) NOT NULL,
	[SPARE_010] [char](2) NOT NULL,
	[SPARE_011] [char](2) NOT NULL,
	[SPARE_012] [char](2) NOT NULL,
	[SPARE_013] [char](2) NOT NULL,
	[SPARE_014] [char](2) NOT NULL,
	[SPARE_015] [char](2) NOT NULL,
	[SPARE_016] [char](2) NOT NULL,
	[SPARE_017] [char](2) NOT NULL,
	[SB_DATA_SB_PARTS_NO] [char](10) NOT NULL,
	[SB_DATA_SB_SERIAL_NO] [char](6) NOT NULL,
	[SB_DATA_GASKET_GRADE] [char](2) NOT NULL,
	[LINE_ON_TIME] [datetime] NOT NULL,
	[LINE_OFF_TIME] [datetime] NOT NULL,
	[RPCOCF_SBLO_BCT] [char](2) NOT NULL,
	[RPCOCF_SBLO_CRT] [char](2) NOT NULL,
	[RPCOCF_SBLO_CTM] [char](2) NOT NULL,
	[RPCOCF_SBLO_SPARE01] [char](2) NOT NULL,
	[RPCOCF_SBLO_SPARE02] [char](2) NOT NULL,
	[RPCOCF_SBLO_SPARE03] [char](2) NOT NULL,
	[RPCOCF_MALO_CCT] [char](2) NOT NULL,
	[RPCOCF_MALO_DPT] [char](2) NOT NULL,
	[RPCOCF_MALO_FWT] [char](2) NOT NULL,
	[RPCOCF_MALO_SPARE01] [char](2) NOT NULL,
	[RPCOCF_MALO_SPARE02] [char](2) NOT NULL,
	[RPCOCF_MALO_SPARE03] [char](2) NOT NULL,
	[RPCOCF_MBLO_HDT] [char](2) NOT NULL,
	[RPCOCF_MBLO_CCT] [char](2) NOT NULL,
	[RPCOCF_MBLO_HCT] [char](2) NOT NULL,
	[RPCOCF_MBLO_PPT] [char](2) NOT NULL,
	[RPCOCF_MBLO_SPARE01] [char](2) NOT NULL,
	[RPCOCF_MBLO_SPARE02] [char](2) NOT NULL,
	[RPCOCF_MBLO_SPARE03] [char](2) NOT NULL,
	[RPCOCF_MBLO_SPARE04] [char](2) NOT NULL,
	[INSPSJ_INSPECTION01] [char](2) NOT NULL,
	[INSPSJ_INSPECTION02] [char](2) NOT NULL,
	[INSPSJ_INSPECTION03] [char](2) NOT NULL,
	[INSPSJ_INSPECTION04] [char](2) NOT NULL,
	[INSPSJ_INSPECTION05] [char](2) NOT NULL,
	[INSPSJ_INSPECTION06] [char](2) NOT NULL,
	[INSPSJ_INSPECTION_TIME01] [datetime] NOT NULL,
	[INSPSJ_INSPECTION11] [char](2) NOT NULL,
	[INSPSJ_INSPECTION12] [char](2) NOT NULL,
	[INSPSJ_INSPECTION13] [char](2) NOT NULL,
	[INSPSJ_INSPECTION14] [char](2) NOT NULL,
	[INSPSJ_INSPECTION15] [char](2) NOT NULL,
	[INSPSJ_INSPECTION16] [char](2) NOT NULL,
	[INSPSJ_INSPECTION_TIME02] [datetime] NOT NULL,
	[CREATED_BY] [varchar](255) NOT NULL,
	[UPDATED_BY] [varchar](255) NULL,
	[CREATED_WHEN] [datetime] NOT NULL,
	[UPDATED_WHEN] [datetime] NULL,
 CONSTRAINT [PK_BALL_ENGINE_LIST] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[BALL_ENGINE_LIST] ADD  CONSTRAINT [DF_BALL_ENGINE_LIST_CREATED_WHEN]  DEFAULT (getdate()) FOR [CREATED_WHEN]
GO


