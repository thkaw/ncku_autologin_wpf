using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ncku_autologin_wpf
{
    public class SerializeHelper
    {

        private LoginInformation INFO { get; set; }


        //序列化函式
        public void SerializeBinary(LoginInformation info)
        {

            this.INFO = info;

            //建立資料流物件
            FileStream oFileStream = new FileStream("loggerinfo.txt", FileMode.Create);
            //建立二進位格式化物件
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("二進位格式序列化......");
            //將物件進行二進位格式序列化，並且將之儲存成檔案
            myBinaryFormatter.Serialize(oFileStream, INFO);
            oFileStream.Flush();
            oFileStream.Close();
            oFileStream.Dispose();
            Console.WriteLine("完成進位格式序列化......");
        }

        //反序列函式
        public LoginInformation DeSerialize()
        {
            FileStream oFileStream = new FileStream("loggerinfo.txt", FileMode.Open);
            BinaryFormatter myBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("開始還原序列化物件......");
            //將檔案還原成原來的物件
            INFO = (LoginInformation)myBinaryFormatter.Deserialize(oFileStream);           

            oFileStream.Flush();
            oFileStream.Close();
            oFileStream.Dispose();

            return INFO;
        }
    }
}
