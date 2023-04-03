using System;
using System.Windows.Forms;

namespace Allinpay
{
    public partial class Form_Main : Form
    {
        RequestClient requestClient = new RequestClient();
        public Form_Main()
        {
            InitializeComponent();
            ConnectDevice();

           
        }

        public void ConnectDevice()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
            allinpayRequestModel.OPER_NO = "01";
            allinpayRequestModel.BUSINESS_ID = "500100001";
            allinpayRequestModel.AMOUNT = "000000000010";
            allinpayRequestModel.CURRENCY = MisConfig.CURRENCY;
            allinpayRequestModel.TRANS_ORDER_NO = RequestClient.getTransTraceNo();
            allinpayRequestModel.BUS_INFO = "01";
            await requestClient.PostAllinPayApiService(allinpayRequestModel);
        }


        //public void auth() throws IOException
        //{
        //    Map<String, String> param = new HashMap<>();
        //param.put("OPER_NO", "01");
        //param.put("BUSINESS_ID", "500100001");
        //param.put("AMOUNT", "000000000010");
        //param.put("CURRENCY", MisConfig.CURRENCY);
        //param.put("TRANS_TRACE_NO", RequestClient.getTransTraceNo());
        //param.put("BUS_INFO", "01");
        //RequestClient.post(param);
        //}

    }
}
