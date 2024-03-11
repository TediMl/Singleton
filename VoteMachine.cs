using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VoteMachine
    {
        private static VoteMachine _instance = null;

        private int _totalVote;
        private static readonly object lockOb = new object();

        private VoteMachine()
        {
        }
        public static VoteMachine Instance //access the single instance of the class
        {
            get
            {
                if (_instance == null) //thread-safe Sing
                {
                    lock (lockOb)
                    {
                        if (_instance == null)
                        {
                            _instance = new VoteMachine();
                        }
                    }
                }
                return _instance;
            }
        }

        public void RegisterVote()
        {
            lock (lockOb)
            {
                _totalVote += 1;
                Console.WriteLine("Registered Vote #" + _totalVote);

            }

        }

        public int TotalVote
        {

            get
            {
                lock (lockOb)
                {
                    return _totalVote;
                }
            }
        }
    }
}





