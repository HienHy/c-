using System;
namespace T2204M_C.exp.as8
{
	public class News:INews
	{
        private int id;
        private String title;
        private String publishDate;
        private String author;
        private String content;
        private float averageRate;

        public News(int id, string title, string publishDate, string author, string content, float averageRate)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;
            this.averageRate = averageRate;
        }


        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverageRate
        {
            get => averageRate;
        }


        public News()
		{
		}

        public void Display()
        {
            Console.WriteLine("Title:"+Title+
                 "PublishDate:"+ PublishDate +
                "Author:" + Author+
                "Content:"+ Content+
                "AverageRate:" + AverageRate);

            throw new NotImplementedException();
        }
    }
}

