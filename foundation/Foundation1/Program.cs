using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Video video1 = new("Supergirl - All Scenes Powers","Explore white", 346);
        video1.Addcomment(new Comment("CatalinaLinal7710","She deserved her own movie, Sasha Calle was amazing as Supergirl!"));
        video1.Addcomment(new Comment("chrisbutch3470","She’s the best part of the whole film."));
        video1.Addcomment(new Comment("erinboateng5961","This movie may have its cons, but you have to admit the supergirl costume is epic."));

        Video video2 = new("Hype Matchup Goes NEXT-LEVEL","Red bull BC", 448);
        video2.Addcomment(new Comment("Flashback_Jack","Now THIS should have been in the 2024 olympics."));
        video2.Addcomment(new Comment("mydreaminorbit9297","Great stuff from Data and Gravity. However Issin and Shigekix are just relentless."));
        video2.Addcomment(new Comment("MrSalmanmuzaffar1","Them Asians on a different level. It’s not even a competition."));

        Video video3 = new("Crazy Funniest Videos That Can Only Be Seen In Africa!","Funny Square",528);
        video3.Addcomment(new Comment("BryanMuhoozi14","The energy in this video is contagious! You can't watch these funny fails without laughing along."));
        video3.Addcomment(new Comment("QuepasseMilanos","This is so funny I love it."));
        video3.Addcomment(new Comment("Roland4real8","This video highlights some truly astonishing people!"));

        List<Video> _video = new() {video1, video2, video3};

        foreach (Video watched in _video)
        {
            Console.WriteLine($"Title: {watched._title}");
            Console.WriteLine($"Author: {watched._author}");
            Console.WriteLine($"Length: {watched._length} seconds");
            Console.WriteLine($"No. of comments {watched.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in watched.GetComments())
            {
                Console.WriteLine($"Commenter Name: {comment._name}");
                Console.WriteLine($"Commenters Text: {comment._text}");
                Console.WriteLine();

            }
        }
    }   
}
