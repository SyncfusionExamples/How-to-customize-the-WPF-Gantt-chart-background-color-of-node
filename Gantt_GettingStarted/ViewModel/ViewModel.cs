
namespace Gantt_GettingStarted
{
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// View model class.
    /// </summary>
    public class ViewModel
    {
        /// <summary>
        /// private field for team details
        /// </summary>
        private ObservableCollection<Item> teamDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            this.teamDetails = this.GetTeamInfo();
        }

        /// <summary>
        /// Gets or sets the appointment item source.
        /// </summary>
        /// <value>The appointment item source.</value>
        public ObservableCollection<Item> TeamDetails
        {
            get
            {
                return this.teamDetails;
            }

            set
            {
                this.teamDetails = value;
            }
        }

        /// <summary>
        /// Gets the team info.
        /// </summary>
        /// <returns>returns the team info</returns>
        public ObservableCollection<Item> GetTeamInfo()
        {
            ObservableCollection<Item> teams = new ObservableCollection<Item>();

            teams.Add(new Item() { Name = "RDU Team" });
            Item Person = new Item() { Name = "Robert" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 17, 12, 0, 0), FinishDate = new DateTime(2012, 01, 21), Name = "Design Spec" });
            teams[0].SubItems.Add(Person);

            Person = new Item() { Name = "Michael" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 19, 12, 0, 0), FinishDate = new DateTime(2012, 01, 23), Name = "Requirement Spec" });
            teams[0].SubItems.Add(Person);



            teams.Add(new Item() { Name = "Graphics Team" });
            Person = new Item() { Name = "Madhan" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 21, 12, 0, 0), FinishDate = new DateTime(2012, 01, 26), Name = "Defining UI Design" });
            teams[1].SubItems.Add(Person);

            Person = new Item() { Name = "Peter" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 24, 12, 0, 0), FinishDate = new DateTime(2012, 01, 28), Name = "Completing Overall Graphics design" });
            teams[1].SubItems.Add(Person);


            teams.Add(new Item() { Name = "Dev Team" });
            Person = new Item() { Name = "Ruban" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 26, 12, 0, 0), FinishDate = new DateTime(2012, 01, 30), Name = "Development Plan", Progress = 10 });
            teams[2].SubItems.Add(Person);

            Person = new Item() { Name = "Karthick" };
            Person.InLineItems.Add(new Item() { StartDate = new DateTime(2012, 01, 29, 12, 0, 0), FinishDate = new DateTime(2012, 02, 2), Name = "Self Testing" });
            teams[2].SubItems.Add(Person);


            return teams;
        }
    }
}
