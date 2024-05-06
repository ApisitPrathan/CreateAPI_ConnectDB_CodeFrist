using System.ComponentModel.DataAnnotations;
using WebApplication1.Data;

namespace WebApplication1.Model
{
    
    public class Count
    {
        public static int _count;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public static int AddView()
        {
            _count++;
            
            return _count;
        }
        public static int GetView() 
        {
            return _count;
        }
        public static void ResetView()
        {
            _count = 0;
        }
    }
}
