using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_034_AlfiNurAziz.Program;

namespace ClientRest_034_AlfiNurAziz
{
    class ClassData
    {
        public void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:8733/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("NAMA: " + mhs.nama);
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}
