using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdesso.Application.Messages
{
    public class ResultMessages
    {
        public ResultMessages(string objectName)
        {
            ObjectName = objectName;
        }
        private  string ObjectName { get; set; }
        public  string SuccessAdded => String.Format($"{ObjectName} Ekleme İşlemi Başarıyla Gerçekleşti");
        public  string ErrorAdded => String.Format($"{ObjectName} Ekleme İşleminde Bir Hata Meydana Geldi !");

    }
}
