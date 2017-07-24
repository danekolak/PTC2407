using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCData
{
    public class TrainingProductManager
    {
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public bool Validate(TrainingProduct entity) 
        {
            ValidationErrors.Clear();
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("ProductName ", "Product name must not be all lower case"));
                }

            }
            return (ValidationErrors.Count == 0);
        }

        public bool Delete(TrainingProduct entity)
        {
             
            return true;
        }
        public TrainingProduct Get(int productId)
        {
            List<TrainingProduct> list = new List<TrainingProduct>();
            TrainingProduct ret = new TrainingProduct();


            list = CreateMockData();
            ret = list.Find(p => p.ProductId == productId);
            return ret; 
        }

        public bool Update(TrainingProduct entity)
        {
            bool ret = false;

            ret = Validate(entity);
            if(ret)
            {

            }
            return ret;
        }
        public bool Insert(TrainingProduct entity)
        {
            bool ret = false;
            ret = Validate(entity);
            if (ret)
            {
                
            }
            return ret;
        }
        public List<TrainingProduct> Get(TrainingProduct entity)
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();
            ret = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }

            return ret;
        }
        private List<TrainingProduct> CreateMockData()
        {
            List<TrainingProduct> ret = new List<TrainingProduct>();
               
            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "Extending Bootstrap with CSS,JavaScript and JQuery",
                IntroductionDate=Convert.ToDateTime("6/11/2016 08:10:00 AM"),
                Url="http://bit.ly/lSNzc0i",
                Price=Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 2,
                ProductName = "Build your own Bootstrap Business Application Template",
                IntroductionDate = Convert.ToDateTime("30/1/2016 08:10:00 PM"),
                Url = "http://bit.ly/1I8ZqZg",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 3,
                ProductName = "Building Mobile Web Sites Using Web Forms, Bootstrap, JQuery",
                IntroductionDate = Convert.ToDateTime("8/10/2016 01:10:00 PM"),
                Url = "http://bit.ly/1J2dcrj",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 4,
                ProductName = "How to start and Run A Consulting Business",
                IntroductionDate = Convert.ToDateTime("9/12/2016 02:10:00 PM"),
                Url = "http://bit.ly/1L8kOwd",
                Price = Convert.ToDecimal(29.00)
            });

            ret.Add(new TrainingProduct()
            {
                ProductId = 5,
                ProductName = "The Many Approaches to XML Processing in .NET Application",
                IntroductionDate = Convert.ToDateTime("22/7/2016 11:10:00 AM"),
                Url = "http://bit.ly/1DBfUgd",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 6,
                ProductName = "WPF for the Visual Basic Programmer - Part 1",
                IntroductionDate = Convert.ToDateTime("16/12/2016 09:00:00 AM"),
                Url = "http://bit.ly/1uFxS7C",
                Price = Convert.ToDecimal(29.00)
            });
            ret.Add(new TrainingProduct()
            {
                ProductId = 7,
                ProductName = "WPF for the Visual Basic Programmer - Part 2",
                IntroductionDate = Convert.ToDateTime("18/10/2016 06:10:00 PM"),
                Url = "http://bit.ly/1MjO9NG",
                Price = Convert.ToDecimal(29.00)
            });

            return ret;
        }
    }
}
 