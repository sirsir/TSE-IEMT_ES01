Public Class frmWorkingDataShowBall
    'Private m_dtEngineView As DataSet1.V_WORKING_DATA_STATICDataTable
    Private m_dtEngineList As DataSet1.ENGINE_LISTDataTable
    Private m_dtWorkingString As DataSet1.WORKING_DATA_STRDataTable
    Private m_dtWorkingInteger As DataSet1.WORKING_DATA_INTDataTable
    Private m_dtWorkingDatetime As DataSet1.WORKING_DATA_DATETIMEDataTable
    Private m_dtSettingColumns As DataSet1.V_SETTING_COLUMNSDataTable

    'Private m_taEngineView As DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter
    Private m_taEngineList As DataSet1TableAdapters.ENGINE_LISTTableAdapter
    Private m_taWorkingString As DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
    Private m_taWorkingInteger As DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
    Private m_taWorkingDatetime As DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
    Private m_taSettingColumns As DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter

    Public Property pp_wdsWORKING_TYPE_ID As Integer
    Public Property pp_wdsENGINE_NO As String

    'Friend WithEvents m_objPivotGrid As ctrlPivotGrid

    Private Sub frmWorkingDataShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Public Sub LoadData()
        'm_taEngineView.FillAllRevEngIdAndWorkingTypeId(m_dtEngineView, 6, 2)
        m_dtWorkingString = Nothing
        m_dtWorkingInteger = Nothing
        m_dtWorkingDatetime = Nothing
        m_taSettingColumns = Nothing
        'm_dtEngineView = m_taEngineView.GetAllRevByEngIdAndWorkingTypeId(38, 11)
        'm_taEngineView.FillByEngineNo(m_dtEngineView, 11)
        'MsgBox(pp_wdsWORKING_TYPE_ID.ToString)
        'm_dtEngineView = m_taEngineView.GetDataByEngineNo(pp_wdsENGINE_NO)
        m_dtEngineList = m_taEngineList.GetDataByEngineNo(modGlobalVariables.arrIn(0))

        'm_dtWorkingString = m_taWorkingString.GetDataByWORKING_ENGINE_NO(pp_wdsWORKING_TYPE_ID, pp_wdsENGINE_NO)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWORKING_ENGINE_NO(pp_wdsWORKING_TYPE_ID, pp_wdsENGINE_NO)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWORKING_ENGINE_NO(pp_wdsWORKING_TYPE_ID, pp_wdsENGINE_NO)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(pp_wdsWORKING_TYPE_ID)

        '"ENGINE_ID" _

        Dim strHiddenColNames() As String = {"ENGINE_ID" _
                                              , "ID" _
                                              , "ENGINE_TYPE" _
                                              , "BOOK" _
                                              , "YEAR" _
                                              , "AT_MT" _
                                              , "EMISSION" _
                                              , "INJ_MODEL_CODE" _
                                              , "SPARE_001" _
                                              , "SB_DATA_SB_PARTS_NO" _
                                              , "SB_DATA_SB_SERIAL_NO" _
                                              , "SB_DATA_GASKET_GRADE" _
                                              , "LINE_ON_TIME" _
                                              , "LINE_OFF_TIME" _
                                              , "RPCOCF_SBLO_BCT" _
                                              , "RPCOCF_SBLO_CRT" _
                                              , "RPCOCF_SBLO_CTM" _
                                              , "RPCOCF_SBLO_SPARE01" _
                                              , "RPCOCF_SBLO_SPARE02" _
                                              , "RPCOCF_SBLO_SPARE03" _
                                              , "RPCOCF_MALO_CCT" _
                                              , "RPCOCF_MALO_DPT" _
                                              , "RPCOCF_MALO_FWT" _
                                              , "RPCOCF_MALO_SPARE01" _
                                              , "RPCOCF_MALO_SPARE02" _
                                              , "RPCOCF_MALO_SPARE03" _
                                              , "RPCOCF_MBLO_HDT" _
                                              , "RPCOCF_MBLO_CCT" _
                                              , "RPCOCF_MBLO_HCT" _
                                              , "RPCOCF_MBLO_PPT" _
                                              , "RPCOCF_MBLO_SPARE01" _
                                              , "RPCOCF_MBLO_SPARE02" _
                                              , "RPCOCF_MBLO_SPARE03" _
                                              , "RPCOCF_MBLO_SPARE04" _
                                              , "INSPSJ_INSPECTION01" _
                                              , "INSPSJ_INSPECTION02" _
                                              , "INSPSJ_INSPECTION03" _
                                              , "INSPSJ_INSPECTION04" _
                                              , "INSPSJ_INSPECTION05" _
                                              , "INSPSJ_INSPECTION06" _
                                              , "INSPSJ_INSPECTION_TIME01" _
                                              , "INSPSJ_INSPECTION11" _
                                              , "INSPSJ_INSPECTION12" _
                                              , "INSPSJ_INSPECTION13" _
                                              , "INSPSJ_INSPECTION14" _
                                              , "INSPSJ_INSPECTION15" _
                                              , "INSPSJ_INSPECTION16" _
                                              , "INSPSJ_INSPECTION_TIME02" _
                                              , "UPDATED_BY" _
                                              , "CREATED_WHEN" _
                                              , "UPDATED_WHEN"}
        ' , {"ENGINE_ID", "REV_NO"} _
        CtrlPivotGrid1.SetDataSource(m_dtEngineList _
                                           , m_dtWorkingString _
                                           , m_dtWorkingInteger _
                                           , m_dtWorkingDatetime _
                                           , m_dtSettingColumns _
                                           , {"ID"} _
                                           , "WORKING_COLUMNS_ID" _
                                           , {"ENGINE_ID"} _
                                           , "DATA" _
                                           , strHiddenColNames)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'm_dtEngineView = New DataSet1.V_WORKING_DATA_STATICDataTable
        m_dtEngineList = New DataSet1.ENGINE_LISTDataTable
        m_dtWorkingString = New DataSet1.WORKING_DATA_STRDataTable
        m_dtWorkingInteger = New DataSet1.WORKING_DATA_INTDataTable
        m_dtWorkingDatetime = New DataSet1.WORKING_DATA_DATETIMEDataTable
        m_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        'm_objPivotGrid = New ctrlPivotGrid
        'm_taEngineView = New DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter
        m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter
        m_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        m_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        m_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter

    End Sub

    Private Sub frmWorkingDataShow_Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try/Catch exception in every event, not in every function
        Try
            LoadData()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub
End Class
