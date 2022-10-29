using ActorsApp.Models;

namespace ActorsApp.Service
{
    public class InMemoryDatabase
    {
        List<Actor> actorList = new List<Actor>()
        {
            new Actor{ Id = 1, StageName="Sallu Bhai" , FirstName="Salman" ,LastName="Khan" , Age=50 , BestMovie="Wanted",
            Image="https://superstarsbio.com/wp-content/uploads/2018/08/salman-khan.jpg",Description="One of the most popular actor in Indian Cinema"},
            new Actor{ Id = 2, StageName="King Khan" , FirstName="Sharukh" ,LastName="Khan" , Age=52 , BestMovie="DDLJ",
            Image="https://www.filmibeat.com/img/popcorn/profile_photos/shahrukh-khan-20190625140849-86.jpg",Description="One of the most popular actor in Indian Cinema"},
            new Actor{ Id = 3, StageName="Sid" , FirstName="Siddharth" ,LastName="malhotra" , Age=40 , BestMovie="Student Of The Year",
            Image="https://i.pinimg.com/236x/09/be/92/09be92776fba3df3de225aa31afa178d.jpg",Description="One of the most popular actor in Indian Cinema"}
        };

        public List<Actor> getAllActor()
        {
            return actorList;
        }

    }
}
