using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
      public class StackOverflowPost
    {
        // خصائص للقراءة فقط (Read-only properties) كما يظهر في الـ Main
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        private int _votes;

        // الـ Constructor لاستقبال العنوان والوصف عند إنشاء الكائن
        public StackOverflowPost(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            _votes = 0;
        }

        // ميثود التصويت بالإيجاب
        public void UpVote()
        {
            _votes++;
        }

        // ميثود التصويت بالسلب
        public void DownVote()
        {
            _votes--;
        }

        // ميثود الحصول على عدد الأصوات الحالي
        public int GetCurrentVote()
        {
            return _votes;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء المنشور كما في الصورة تماماً
            StackOverflowPost stackOverflowPost = new StackOverflowPost("C#Basic", "dffsdffffffffrrrrrrrrr");

            do
            {
                // عرض البيانات كما في الصورة
                Console.WriteLine("Title: " + stackOverflowPost.Title);
                Console.WriteLine("Description: " + stackOverflowPost.Description);
                Console.WriteLine("Created At: " + stackOverflowPost.CreatedAt);
                Console.WriteLine("Current Votes: " + stackOverflowPost.GetCurrentVote());

                Console.WriteLine("\nUp Vote press 1");
                Console.WriteLine("Down Vote press 2");

                var s = Console.ReadLine();
                int x=Convert.ToInt32(s);
                // التأكد من أن المدخل رقم لتجنب توقف البرنامج
                
                if (x == 1)
                {
                    stackOverflowPost.UpVote();
                }
                else if (x == 2)
                {
                    stackOverflowPost.DownVote();
                }
                else
                {
                    break; // الخروج من الحلقة
                }

                Console.Clear();

            } while (true);
        }
    }
}
