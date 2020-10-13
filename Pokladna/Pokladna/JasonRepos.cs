using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokladna
{
    public class JasonRepos : IRepos
    {
        private string datovySoubor;
        public JasonRepos(string soubor)
        {
            datovySoubor = soubor;
        }
        public void VytvorData()
        {
            List<PoklZaznam> data = new List<PoklZaznam>();
            data.Add(new PoklZaznam(1, 1, new DateTime(2020, 1, 3), "Příjem z banky", 20000, 20000, ""));
            data.Add(new PoklZaznam(2, 2, new DateTime(2020, 1, 4), "Tenisové míče", -2356, data.Last().Zustatek - 2356, "Dotace MŠMT"));
            data.Add(new PoklZaznam(3, 3, new DateTime(2020, 1, 8), "Občerstvení",-538, data.Last().Zustatek - 538, ""));
            data.Add(new PoklZaznam(4, 4, new DateTime(2020, 1, 10), "Pronájem kartu", 350, data.Last().Zustatek + 350, ""));
            data.Add(new PoklZaznam(5, 5, new DateTime(2020, 1, 12), "Registrace soutěží", 2500, data.Last().Zustatek - 2500, ""));

            string json = JsonConvert.SerializeObject(data);

            File.WriteAllText(datovySoubor, json);
        }

        public List<PoklZaznam>NactiVse()
        {
            List<PoklZaznam> data;
            return data = JsonConvert.DeserializeObject<List<PoklZaznam>>(File.ReadAllText(datovySoubor));
        }

        public PoklZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam VytvorZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
