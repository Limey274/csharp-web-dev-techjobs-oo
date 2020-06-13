using System;
namespace TechJobsOO
{
    public class Location : JobField
    {
        //************************************ chunk 1
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public Location()
        //{
        //    Id = nextId;
        //    nextId++;
        //}
       //*************************   chunk1 gets placed into the Jobfield class because all fields require ID and and value. 

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.
        

      //added "base(value) from : this --> this is being pushed back to the Jobfield class, and "this" keeps the value within the same class. 
        //THIS IS THE ONLY THING NEEDED IN THE FILE AND ALL OTHER FILES. Look at the other files for cleaned up files.
                        public Location(string value) : base(value)   
                        {
                                 Value = value;
                         }


        //****************************** chunk 2

        //public override bool Equals(object obj)
        //{
        //    return obj is Location location &&
        //           Id == location.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}
    //******************************* chunk2 gets placed into the Jobfield class because all fields require ID and value
    }
}
