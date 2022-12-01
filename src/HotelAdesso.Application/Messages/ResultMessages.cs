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
        public  string SuccessDelete => String.Format($"{ObjectName} Silme İşlemi Başarıyla Gerçekleşti !");
        public  string SuccessList => String.Format($"{ObjectName} Listeleme İşlemi Başarıyla Gerçekleşti !");
        public  string SuccessUpdate => String.Format($"{ObjectName} Güncelleme İşlemi Başarıyla Gerçekleşti !");
        public  string ErrorAdded => String.Format($"{ObjectName} Ekleme İşleminde Bir Hata Meydana Geldi !");
        public  string ErrorDelete => String.Format($"{ObjectName} Silme İşleminde Bir Hata Meydana Geldi !");
        public  string ErrorList => String.Format($"{ObjectName} Listeleme İşleminde Bir Hata Meydana Geldi !");
        public  string ErrorUpdate => String.Format($"{ObjectName} Güncelleme İşleminde Bir Hata Meydana Geldi !");

    }
}
