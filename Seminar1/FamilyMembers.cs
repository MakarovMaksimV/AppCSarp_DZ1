using System;
namespace Seminar1
{
	public class FamilyMembers
	{
        public string Relationship { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public string FullName { get; set; }
        public FamilyMembers Mother { get; set; }
        public FamilyMembers Father { get; set; }
        public FamilyMembers [] Children { get; set; }
        public FamilyMembers Consort { get; set; }

        public FamilyMembers(string Relationship, int Age, Gender gender, string FullName)
        {
            this.Relationship = Relationship;
            this.Age = Age;
            this.gender = gender;
            this.FullName = FullName;
        }

        public FamilyMembers(FamilyMembers [] Children)
        {
            this.Children = Children;
        }

        public FamilyMembers()
        {

        }

        public FamilyMembers(string Relationship, int Age, Gender gender, string FullName, FamilyMembers Mother, FamilyMembers Father)
        {
            this.Relationship = Relationship;
            this.Age = Age;
            this.gender = gender;
            this.FullName = FullName;
            this.Father = Father;
            this.Mother = Mother;
        }

        public FamilyMembers[] GetGrandParents(Gender gender)
		{
            if(gender == Gender.male)
			    return new FamilyMembers[]{ Mother.Mother, Father.Mother};
            else
                return new FamilyMembers[] { Father.Father, Mother.Father};
        }

        public FamilyMembers[] GetParents(Gender gender)
        {
            if (gender == Gender.male)
                return new FamilyMembers[] { Mother };
            else
                return new FamilyMembers[] { Father };
        }

        public FamilyMembers[] GetChildern()
        {
            return new FamilyMembers[] { } ;
        }

        public FamilyMembers GetConsort()
        {
            return Consort;
        }
    }
}

