using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuVanQuyet789.Models
{
    public class StringProcessVVQ789
    {
        public string LowerToUpper(string text){
            string newText = text.ToUpper();
            return newText;
        }
    }
}