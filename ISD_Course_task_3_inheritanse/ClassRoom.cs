using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_3_inheritanse
{
    class ClassRoom
    {
        private List<Pupil> pupilList = new List<Pupil>();
        public ClassRoom(Pupil ppl1)
        {
            pupilList.Add(ppl1);
        }
        public ClassRoom(Pupil ppl1, Pupil ppl2)
            : this(ppl2)
        {
            pupilList.Add(ppl1);
        }
        public ClassRoom(Pupil ppl1, Pupil ppl2, Pupil ppl3)
            : this(ppl2, ppl3)
        {
            pupilList.Add(ppl1);
        }
        public void AddPupil(Pupil ppl)
        {
            if (pupilList.Count < 4)
            {
                pupilList.Add(ppl);
            }
            else
            {
                Console.WriteLine("Class is full!");
            }
        }
        public void ShowRating()
        {
            for (int i = 0; i < pupilList.Count; i++)
            {
                Console.WriteLine("Pupil {0}", i + 1);
                pupilList[i].Study();
                pupilList[i].Read();
                pupilList[i].Write();
                pupilList[i].Relax();
            }
        }
    }
    class Pupil
    {
        public virtual void Study()
        {

        }
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
    }

    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tStudy: 100%");
        }
        public override void Read()
        {
            Console.WriteLine("\tRead: 100%");
        }
        public override void Write()
        {
            Console.WriteLine("\tWrite: 100%");
        }
        public override void Relax()
        {
            Console.WriteLine("\tRealx: 10%");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tStudy: 80%");
        }
        public override void Read()
        {
            Console.WriteLine("\tRead: 80%");
        }
        public override void Write()
        {
            Console.WriteLine("\tWrite: 90%");
        }
        public override void Relax()
        {
            Console.WriteLine("\tRelax: 30%");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("\tStudy: 20%");
        }
        public override void Read()
        {
            Console.WriteLine("\tRead: 40%");
        }
        public override void Write()
        {
            Console.WriteLine("\tWrite: 30%");
        }
        public override void Relax()
        {
            Console.WriteLine("\tRelax: 80%");
        }
    }
}
