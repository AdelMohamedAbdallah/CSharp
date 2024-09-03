#nullable disable
using C__Course.Serialization;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace C__Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //Student[] students =
            //{
            //    new Student{name = "Adel" , id = 32},
            //    new Student{name = "Abdo" , id = 76} ,
            //    new Student{name = "Emad" , id = 54}
            //};

            //Student st = new Student();
            //List<Student> studentlist = new List<Student>();
            //studentlist.AddRange(students);
            //studentlist.Add(new Student { name = "Eslam", id = 87 });
            //Console.WriteLine("*Students which there name start \"A\" ");
            //studentlist.FindAll((Student x) => x.name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            //st.Print(studentlist);
            //Console.WriteLine("*Students before Remove\n");
            //st.Print(studentlist);
            //studentlist.RemoveAll(x => x.name.StartsWith("E"));
            //Console.WriteLine("*Students after Remove\n");
            //st.Print(studentlist);
            //studentlist.Remove(new Student { name = "Abdo", id = 76 });
            //st.Print(studentlist);
            //sw.Stop();
            //Console.WriteLine($"Excuting time {sw.ElapsedMilliseconds} ms");


            //string name1 = "Adel";
            //bool testequal = name1.Equals("adel", StringComparison.OrdinalIgnoreCase);
            //Console.WriteLine(testequal);

            //Number n1 = new Number(6);
            //Number n2 = new Number(14);
            //Number n3 = n1 + n2;
            //Console.WriteLine(n3.num);

            //var articl = "My name is Adel I'm student in fuclty of scince I hope to be web developer I learn the Dot net backend" +
            //    "I love this to be succses in my work";
            //Dictionary<char, List<string>> getlitters = new Dictionary<char, List<string>>();
            //foreach (var word in articl.Split())
            //{
            //    foreach (char charactar in word)
            //    {
            //        if (!getlitters.ContainsKey(charactar))
            //        {
            //            getlitters.Add(charactar, new List<string>() { word });
            //        }
            //        else
            //        {
            //            getlitters[charactar].Add(word);
            //        }
            //    }
            //}
            //foreach (var item in getlitters)
            //{
            //    Console.WriteLine($"\"{item.Key}\" : \n");
            //    foreach (var word in item.Value)
            //    {
            //        Console.WriteLine($"\t\t\t\t*{word}.\n");
            //    }
            //    Console.WriteLine("**********************************************");
            //}
            //Console.WriteLine($"The Memory befor Carbage collection {GC.GetTotalMemory(false):N} bit");
            //GC.Collect();
            //Console.WriteLine($"The Memory After Carbage collection {GC.GetTotalMemory(true):N} bit");


            //TestStack ts = new TestStack();
            //ts.Process_Back_Forward();

            //Queue<TestQueue> student = new Queue<TestQueue>();
            //student.Enqueue(new TestQueue("Adel", 23, 3));
            //student.Enqueue(new TestQueue("Abdo", 65, 4));
            //student.Enqueue(new TestQueue("Emad", 83, 1));
            //student.Enqueue(new TestQueue("Ahmed", 25, 2));
            //student.Enqueue(new TestQueue("Rahma", 75, 4));
            //student.Enqueue(new TestQueue("Reem", 20, 3));
            //student.Enqueue(new TestQueue("Yasmen", 17, 1));

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}
            //int x = 843442101;
            //int y = 429017372;
            //int z;
            //unchecked
            //{
            //    z = x + y;
            //}
            //Console.WriteLine(z);

            //YTVideo[] videos =
            //{
            //    new YTVideo("lesson1","YTVlesson1",new(1,30,00)),
            //    new YTVideo("lesson2","YTVlesson2",new(00,38,00)),
            //    new YTVideo("lesson3","YTVlesson3",new(00,55,00)),
            //    new YTVideo("lesson4","YTVlesson4",new(1,20,00)),
            //    new YTVideo("lesson5","YTVlesson5",new(1,02,00)),
            //    new YTVideo("lesson6","YTVlesson6",new(00,28,00)),
            //    new YTVideo("lesson7","YTVlesson7",new(00,30,00)),
            //    new YTVideo("lesson8","YTVlesson8",new(1,15,00)),
            //};

            //LinkedList<YTVideo> lessons = new LinkedList<YTVideo>(videos);
            //lessons.AddLast(new YTVideo("lesson9", "YTVlesson9", new(1, 10, 00)));
            //foreach (var item in lessons)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashset[] Students1 =
            //{
            //    new Hashset("Adel",65,3),
            //    new Hashset("Abdo",93,4),
            //    new Hashset("Eslam",43,2),
            //};
            //Hashset[] Students2 =
            //{
            //    new Hashset("Amen",72,1),
            //    new Hashset("Ziad",61,3),
            //    new Hashset("Ashraf",17,4),
            //};

            //HashSet<Hashset> Student = new HashSet<Hashset>(Students1);
            //Student.Add(new Hashset("Khaled", 76, 2));
            //Student.UnionWith(Students2);
            //foreach (var item in Student)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("******************");
            //Student.ExceptWith(Students1);
            //foreach (var item in Student)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("******************");
            //Student.IntersectWith(Students2);
            //foreach (var item in Student)
            //{
            //    Console.WriteLine(item);
            //}

            //Customer[] customers =
            //{
            //    new Customer("Khaled",66927),
            //    new Customer("Ahmed",91283),
            //    new Customer("Ziad",108435),
            //    new Customer("Amen",309826),
            //    new Customer("Mohamed",65832),
            //    new Customer("Adel",81238),
            //};

            //SortedSet<Customer> customer = new SortedSet<Customer>(customers);
            //foreach (var item in customer)
            //{
            //    Console.WriteLine(item);
            //}

            //CurrencyService currencyService = new CurrencyService();
            //Console.WriteLine(currencyService);

            //FBComment[] Comments =
            //{
            //    new FBComment("Eslam","I love you",new DateTime(2024,3,24,12,30,45)),
            //    new FBComment("Ahmed","this is butiful photo",new DateTime(2024,4,26,2,27,50)),
            //    new FBComment("Emad","you butiful",new DateTime(2024,1,13,11,12,40)),
            //    new FBComment("Abdo","I love you very mutch",new DateTime(2024,2,16,5,15,20)),
            //    new FBComment("Adel","your photo is very good",new DateTime(2024,5,25,6,23,25)),
            //    new FBComment("Ziad","you in my hart",new DateTime(2024,3,27,8,45,40)),
            //    new FBComment("Kamal","I want to kiss you ",new DateTime(2024,5,1,4,18,55)),
            //};

            //foreach (var item in Comments)
            //{
            //    Console.WriteLine(item);
            //}

            //Wallet w = new Wallet("Adel", 50, "A123d4");
            //Thread th1 = new Thread(new ThreadStart(w.RunProcess));
            //Thread th2 = new Thread(new ThreadStart(w.RunProcess));
            //th1.Name = "First Thread";
            //th2.Name = "Second Thread";
            //th1.Start();
            //th2.Start();
            //Console.WriteLine($"The State of second thread : {th1.ThreadState}");
            //Console.WriteLine($"The State of second thread : {th2.ThreadState}");
            //th1.Join();
            //th2.Join();
            //Task.Run(() => w.RunProcess());
            //Task.Factory.StartNew(() => w.RunProcess());
            //Task.Factory.StartNew(() => w.RunProcess());

            //ThreadPool.QueueUserWorkItem(delegate { w.RunProcess(); });


            var em = new Employee
            {
                Id = 12,
                FName = "Adel",
                LName = "Mohamed",
                Offer = { "holidays", "bouns" }
            };

            //var xmlcontent1 = ConvertToXMLSerializer(em);
            //Console.WriteLine("Serialized XML1:\n");
            //Console.WriteLine(xmlcontent1);
            //File.WriteAllText("XMLDocument1.xml", xmlcontent1);
            //Console.WriteLine("*****************************");
            //var xmlcontent2 = ConvertToXMLSerializationEnhance(em);
            //Console.WriteLine("Serialized XML2:\n");
            //Console.WriteLine(xmlcontent2);
            //File.WriteAllText("XMLDocument2.xml", xmlcontent2);
            //Console.WriteLine("*************************");
            //Employee employee = ConvertToDeSerializer(xmlcontent2);
            //Console.WriteLine(employee);
            //Console.WriteLine($"{File.ReadAllText("XMLDocument2.xml")}");

            //Console.WriteLine("Use the json Serializer \n");
            //var jsoncontent1 = ConvertToJsonSerializer(em);
            //Console.WriteLine(jsoncontent1);
            //Console.WriteLine("Use the json DeSerializer \n");

            //Employee jsoncontent2 = ConvertToJsonDeSerializer(jsoncontent1);
            //Console.WriteLine($"{jsoncontent2.Id}\n{jsoncontent2.FName}\n{jsoncontent2.LName}\n{jsoncontent2.Offer}");


            //StudentRecord st1 = new StudentRecord("Adel", "Mohamed", 32, 3);
            //StudentRecord st2 = new StudentRecord("Adel", "Mohamed", 32, 3);

            //Console.WriteLine(st1.Equals(st2));
            //Console.WriteLine(st1.GetHashCode());
            //Console.WriteLine(st2.GetHashCode());
            //Console.WriteLine(st1 == st2);
            //Console.WriteLine(st1);
            //Console.WriteLine(st2);
            //Console.WriteLine("Use Record type\n");
            //StudentRecordTest stt1 = new StudentRecordTest("Adel", "Mohamed", 32, 3);
            //StudentRecordTest stt2 = new StudentRecordTest("Adel", "Mohamed", 32, 3);
            //Console.WriteLine(stt1.Equals(stt2));
            //Console.WriteLine(stt1.GetHashCode());
            //Console.WriteLine(stt2.GetHashCode());
            //Console.WriteLine(stt1 == stt2);
            //Console.WriteLine(stt1);
            //Console.WriteLine(stt2);
            //Console.WriteLine("Use record position\n");
            //RecordPosition rcordPosition1 = new RecordPosition("Adel", "Mohamed");
            //RecordPosition rcordPosition2 = rcordPosition1 with { fname = "Abdo" };
            //Console.WriteLine(rcordPosition1);
            //Console.WriteLine(rcordPosition2);
            //var (name1, name2) = rcordPosition1;
            //Console.WriteLine($"First name : {name1}");
            //Console.WriteLine($"Last name : {name2}");


            //UnsafeCodeExample example = new UnsafeCodeExample();
            //example.UsePointer();

            //string text = "Hello, world!";
            //byte[] utf8Bytes = Encoding.UTF8.GetBytes(text);
            //byte[] utf16Bytes = Encoding.Unicode.GetBytes(text); // UTF-16
            //byte[] ascii = Encoding.ASCII.GetBytes(text);

            //Console.WriteLine("Use Encodeing with \"UTF8\" To Convert to bytes");
            //foreach (var item in utf8Bytes)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Use Encodeing with \"ASCII\" To Convert to bytes");
            //foreach (var item in ascii)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Use Encodeing with \"Unicode\"");

            //foreach (var item in utf16Bytes)
            //{
            //    Console.WriteLine(item);

            //}

            //byte[] utf32Bytes = Encoding.UTF8.GetPreamble();
            //foreach (var item in utf8Bytes)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Use Encodeing with \"UTF8\" To Convert to string");

            //byte[] GetbyteString = { 72, 101, 108, 108, 111, 44, 32, 119, 111, 114, 108, 100, 33 };
            //string text1 = Encoding.UTF8.GetString(GetbyteString);
            //Console.WriteLine(text1);

            //File.WriteAllText("Testfile.txt", text1);
            //Console.WriteLine($"The file data : \n{File.ReadAllText("Testfile.txt")}");


            //for (byte i = 0; i < 255; i++)
            //{
            //    char c = (char)i; 
            //    string dec = i.ToString().PadLeft(3, '0');
            //    string hex = i.ToString("x");
            //    string binary = Convert.ToString(i, 2).PadLeft(8, '0');
            //    Console.WriteLine($"{dec,-12} {binary,-12} {hex,-12} {c,-12}");
            //}

            //string text2 = "Hello, world!";
            //byte[] unicods = Encoding.UTF8.GetBytes(text2);
            //foreach (byte b in unicods)
            //{
            //    Console.WriteLine(b.ToString("x").PadLeft(4, '0'));
            //}

            //string x = "\u0061"; // this unicode for "a"
            //Console.WriteLine(x);


            //StringBuilder sb = new StringBuilder();
            //sb.Append("Adel Mohammed");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.Capacity);
            //Console.WriteLine($"{sb.MaxCapacity:N0}");

            //var student = Tuple.Create("Adel", 54, 3);
            //Console.WriteLine($"Data of student : {student}");

            //var tuple = (Id: 1, Name: "Adel", IsActive: true);

            //// Access elements
            //int id = tuple.Id;            // 1
            //string name = tuple.Name;     // "example"
            //bool isActive = tuple.IsActive; // true
            //Console.WriteLine($"({name},{id},{isActive})");

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Adel ").Append("Mohamed ").Append("Abdallah");
            //Console.WriteLine(stringBuilder.ToString());

            //var sw = new Stopwatch();
            //sw.Start();
            //LinkedList<int> nums = new LinkedList<int>();
            //nums.AddFirst(30);
            //nums.AddLast(20);
            //nums.AddLast(15);
            //nums.AddLast(10);
            //nums.AddLast(5);

            //HashSet<int> set = new HashSet<int>();
            //foreach (int element in nums)
            //{
            //    int temp = 35 - element;
            //    if (set.Contains(temp))
            //    {
            //        Console.WriteLine($"num1 : {element}\tnum2 :  {temp}");
            //    }
            //    set.Add(element);
            //}
            //sw.Stop();
            //Console.WriteLine($"Operation Time : {sw.ElapsedMilliseconds}ms");

            //Area area = new Area(10, 20);
            //var summary = BenchmarkRunner.Run<Area>();



            Console.ReadKey(true);


        }
        #region ConvertToJsonDeSerializer
        private static Employee ConvertToJsonDeSerializer(string jsoncontent)
        {
            Employee employee = null;
            employee = JsonConvert.DeserializeObject<Employee>(jsoncontent);
            return employee;
        }
        #endregion

        private static String ConvertToJsonSerializer(Employee em)
        {
            var result = "";
            result = JsonConvert.SerializeObject(em, Formatting.Indented);
            return result;
        }

        private static Employee ConvertToDeSerializer(string content)
        {
            Employee employee = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (StringReader sr = new StringReader(content))
            {
                employee = serializer.Deserialize(sr) as Employee;
            }
            return employee;
        }

        private static string ConvertToXMLSerializer(Employee e)
        {
            String result = null;
            var xmlserializer = new XmlSerializer(e.GetType());
            using (var sw = new StringWriter())
            {
                using (var writer = XmlWriter.Create(sw, new XmlWriterSettings { Indent = true }))
                {
                    xmlserializer.Serialize(writer, e);
                    result = sw.ToString();
                }
            }
            return result;
        }
        private static string ConvertToXMLSerializationEnhance(Employee em)
        {
            string xml = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, em);
                xml = writer.ToString();
            }
            return xml;
        }


    }

}
#nullable restore 
