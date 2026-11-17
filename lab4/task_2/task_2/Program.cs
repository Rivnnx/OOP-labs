using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    struct Comment
    {
        public string AuthorNickname;
        public string Text;
        public DateTime CreatedAt;

        public Comment(string authorNickname, string text)
        {
            AuthorNickname = authorNickname;
            Text = text;
            CreatedAt = DateTime.Now;
        }
    }

    class Post
    {
        public DateTime CreatedAt;
        public string Text;
        public int Likes;
        public List<Comment> Comments;

        public Post(string text)
        {
            Text = text;
            CreatedAt = DateTime.Now;
            Likes = 0;
            Comments = new List<Comment>();
        }

        // інформація про пост
        public void PrintFullInfo(int postNumber)
        {
            string formattedDate = CreatedAt.ToString("dd.MM.yyyy HH:mm");
            Console.WriteLine("--- Пост #" + postNumber + " | Дата: " + formattedDate + " ---");
            Console.WriteLine("Текст: " + Text);
            Console.WriteLine("Лайків: " + Likes + " | Коментарів: " + Comments.Count);

            if (Comments.Count > 0)
            {
                Console.WriteLine("Коментарі:");
                for (int i = 0; i < Comments.Count; i++)
                {
                    Comment currentComment = Comments[i];
                    string commentTime = currentComment.CreatedAt.ToString("HH:mm");
                    Console.WriteLine("   [ " + commentTime + " ] " + currentComment.AuthorNickname + ": " + currentComment.Text);
                }
            }
            Console.WriteLine();
        }
    }

    class User
    {
        public string Name;
        public string Email;
        public string Nickname;
        public List<Post> Posts;

        public User(string name, string email, string nickname)
        {
            Name = name;
            Email = email;

            if (nickname.StartsWith("@"))
            {
                Nickname = nickname;
            }
            else
            {
                Nickname = "@" + nickname;
            }

            Posts = new List<Post>();
        }

        public void CreatePost(string text)
        {
            Post newPost = new Post(text);
            Posts.Add(newPost);
            Console.WriteLine(Nickname + " опублікував новий пост.");
        }

        public void DeletePost(int postIndex)
        {
            if (postIndex >= 0 && postIndex < Posts.Count)
            {
                Posts.RemoveAt(postIndex);
                int displayNumber = postIndex + 1;
                Console.WriteLine(Nickname + " видалив пост #" + displayNumber + ".");
            }
            else
            {
                Console.WriteLine("Помилка: у " + Nickname + " немає поста з таким номером.");
            }
        }

        public void LikePost(Post targetPost)
        {
            targetPost.Likes = targetPost.Likes + 1;
            Console.WriteLine(Nickname + " вподобав пост: \"" + targetPost.Text + "\"");
        }

        public void CommentOnPost(Post targetPost, string commentText)
        {
            Comment newComment = new Comment(Nickname, commentText);
            targetPost.Comments.Add(newComment);
            Console.WriteLine(Nickname + " прокоментував пост: \"" + commentText + "\"");
        }

        public void ViewLastFivePosts(User otherUser)
        {
            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Останні пости користувача " + otherUser.Name + " (" + otherUser.Nickname + "):");
            Console.WriteLine("==========================================");

            if (otherUser.Posts.Count == 0)
            {
                Console.WriteLine("У цього користувача ще немає постів.");
                Console.WriteLine();
                return;
            }

            int startIndex = otherUser.Posts.Count - 1;
            int endIndex = otherUser.Posts.Count - 5;

            if (endIndex < 0)
            {
                endIndex = 0;
            }

            for (int i = startIndex; i >= endIndex; i--)
            {
                Post currentPost = otherUser.Posts[i];
                currentPost.PrintFullInfo(i + 1);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // створенні користувачі
            User alex = new User("Олександр", "alex.dev@mail.com", "@alex_code");
            User maria = new User("Марія", "maria.design@mail.com", "@masha_art");
            User dmytro = new User("Дмитро", "dima99@mail.com", "@dima_sec");

            // пости олександра 
            alex.CreatePost("Пост 1: Мій перший день вивчення C#!");
            alex.CreatePost("Пост 2: Розібрався зі структурами та класами.");
            alex.CreatePost("Пост 3: П'ю каву і пишу код.");
            alex.CreatePost("Пост 4: Хто знає хороші курси по кібербезпеці?");
            alex.CreatePost("Пост 5: Сьогодні чудова погода в Києві.");
            alex.CreatePost("Пост 6: Зацініть мій новий пет-проєкт!");

            Console.WriteLine();

            // лайки / коментарі
            maria.LikePost(alex.Posts[5]);
            dmytro.LikePost(alex.Posts[5]);
            maria.CommentOnPost(alex.Posts[5], "Круто вийшло, скинь посилання на GitHub!");
            dmytro.CommentOnPost(alex.Posts[3], "Можу скинути пару хороших платформ для практики.");

            maria.ViewLastFivePosts(alex);

            alex.DeletePost(4);

            dmytro.ViewLastFivePosts(alex);

            Console.ReadLine();
        }
    }
}