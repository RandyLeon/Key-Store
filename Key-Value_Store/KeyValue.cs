using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    class Program
    {
        struct KeyValue
        {
            public string key;
            public readonly object value;

            public KeyValue(string key, object value)
            {
                {
                    this.key = key;
                    this.value = value;
                }
            }
        }

        class MyDictionary
        {
            KeyValue[] kvs = new KeyValue[16];
            int storedValues = 0;

            public object this[string searchKey]
            {
                set
                {
                    bool found = false;

                    for (int i = 0; i < storedValues; ++i)
                    {
                        if (kvs[i].key == searchKey)
                        {
                            found = true;
                            kvs[i] = new KeyValue(searchKey, value);
                        }

                    }

                    if (!found)
                    {
                        kvs[storedValues++] = new KeyValue(searchKey, value);
                    }
                }


                get
                {
                    for (int i = 0; i < storedValues; ++i)
                    {
                        if (kvs[i].key == searchKey)
                        {
                            return kvs[i].value;
                        }
                    }
                    throw new KeyNotFoundException($"Didn't find \" {searchKey}\" in MyDictoinary");

                }
            }
        }

        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}