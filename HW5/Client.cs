using System;


namespace HW5
{
    public class Client
    {

        public string _clientName { set; get; }
        public Client() { }
        public Client(string name)
        {
            //设置客户姓名
            this._clientName = name;
            ClientName = name;
        }
        public string ClientName { set; get; }
        public override string ToString()
        {
            return "clientName:" + _clientName;
        }
    }
}
