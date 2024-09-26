using System.ComponentModel.DataAnnotations;

namespace Valasztasok.Model
{
    public class Jelolt
    {
        public int Id { get; set; }
        public int KeruletID { get; set; }
        public int SzavazatSzam { get; set; }
        public string KepviseloNev { get; set; }
        public Part Part { get; set; }
    }
}
