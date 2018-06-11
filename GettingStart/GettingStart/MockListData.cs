using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStart
{
    public class MockListData
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public string ImageName { get; set; }

        public MockListData(string name, string category, string imageName)
        {
            Name = name;
            Category = category;
            ImageName = imageName;
        }

        public static List<MockListData> GetList()
        {
            List<MockListData> data = new List<MockListData>();

            data.Add(new MockListData("Asparagus", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Avocados", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Beetroots", "Fruits", "Fruits"));
            data.Add(new MockListData("Capsicum", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Broccoli", "Fruits", "Fruits"));
            data.Add(new MockListData("Brussel sprouts", "Fruits", "Fruits"));
            data.Add(new MockListData("Cabbage", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Carrots", "Fruits", "Fruits"));
            data.Add(new MockListData("Cauliflower", "Legumes", "Legumes"));
            data.Add(new MockListData("Celery", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Corn", "Legumes", "Legumes"));
            data.Add(new MockListData("Cucumbers", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Eggplant", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Fennel", "Fruits", "Fruits"));
            data.Add(new MockListData("Garlic", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Beans", "Vegetables", "Legumes"));
            data.Add(new MockListData("Peas", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Kale", "Legumes", "Legumes"));
            data.Add(new MockListData("Leeks", "Vegetables", "Vegetables"));
            data.Add(new MockListData("Mushrooms", "Legumes", "Legumes"));

            return data;
        }
    }
}
