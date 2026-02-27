namespace Encapsulation
{
    //Design a Stopwatch class that has the following features:

    public class StopWatch

    {

        private DateTime _startTime;

        private bool _isRunning;

        private TimeSpan _duration;



        // الخاصية Duration التي تم استدعاؤها في الكود الخاص بك

        public TimeSpan Duration
        {
            get
            {
                // إذا كانت تعمل، احسب الفرق بين الآن ووقت البداية
                if (_isRunning)
                    return DateTime.Now - _startTime;

                // إذا كانت متوقفة، ارجع آخر قيمة مسجلة
                return _duration;
            }
        }



        public void StartTheStopWatch()

        {

            if (_isRunning)

                throw new InvalidOperationException("Stopwatch is already running.");



            _startTime = DateTime.Now;

            _isRunning = true;

        }



        public void StopTheStopWatch()

        {

            if (!_isRunning)

                throw new InvalidOperationException("Stopwatch is not running.");



            // حساب المدة عند الإيقاف وإضافتها للقيمة الحالية

            _duration = DateTime.Now - _startTime;

            _isRunning = false;

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            StopWatch watch = new StopWatch();

            Console.WriteLine("To Start press 0");

            Console.WriteLine("To end press 1");

            Console.WriteLine("To Show interval press 2");

            Console.WriteLine("To exit press 3");



            while (true)

            {

                try

                {

                    string choose = Console.ReadLine();

                    int x = Convert.ToInt32(choose);



                    if (x == 0)

                    {

                        watch.StartTheStopWatch();

                    }

                    if (x == 1)

                    {

                        watch.StopTheStopWatch();

                    }

                    if (x == 2)

                    {

                       // طباعة المدة كما في الصورة
                        Console.WriteLine(watch.Duration);

                    }
                    if (x == 3)
                    {

                        return;
                    }

                }
                catch (InvalidOperationException ex)

                {
                    Console.WriteLine(ex.Message);

                }
                catch (FormatException)

                {
                    Console.WriteLine("Please enter a valid number.");
                }

            }

        }

    }

}

