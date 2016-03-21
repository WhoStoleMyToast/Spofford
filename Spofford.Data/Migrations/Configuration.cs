namespace Spofford.Data.Migrations
{
    using Spofford.Core.Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Spofford.Data.Context.SpoffordDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Spofford.Data.Context.SpoffordDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Players.AddOrUpdate(
              p => p.PlayerID,
                new Player { PlayerID = 1, Name = "James May", HasPaid = true }
                );

            context.Regions.AddOrUpdate(
              r => r.RegionID,
                new Region { RegionID = 1, Name = "South" },
                new Region { RegionID = 2, Name = "West" },
                new Region { RegionID = 3, Name = "Midwest" },
                new Region { RegionID = 4, Name = "East" }
                );

            context.Teams.AddOrUpdate(
              t => t.TeamID,
                new Team { TeamID = 1, Name = "Kansas", Seed = 1, RegionID = 1, Year = 2016 },
                new Team { TeamID = 2, Name = "NorthCarolina", Seed = 1, RegionID = 1, Year = 2016 },
                new Team { TeamID = 3, Name = "Virginia", Seed = 1, RegionID = 1, Year = 2016 },
                new Team { TeamID = 4, Name = "Oregon", Seed = 1, RegionID = 1, Year = 2016 },
                new Team { TeamID = 5, Name = "MichiganState", Seed = 2, RegionID = 1, Year = 2016 },
                new Team { TeamID = 6, Name = "Oklahoma", Seed = 2, RegionID = 1, Year = 2016 },
                new Team { TeamID = 7, Name = "Villanova", Seed = 2, RegionID = 1, Year = 2016 },
                new Team { TeamID = 8, Name = "Xavier", Seed = 2, RegionID = 1, Year = 2016 },
                new Team { TeamID = 9, Name = "WestVirginia", Seed = 3, RegionID = 1, Year = 2016 },
                new Team { TeamID = 10, Name = "Miami", Seed = 3, RegionID = 1, Year = 2016 },
                new Team { TeamID = 11, Name = "Utah", Seed = 3, RegionID = 1, Year = 2016 },
                new Team { TeamID = 12, Name = "TexasA and M", Seed = 3, RegionID = 1, Year = 2016 },
                new Team { TeamID = 13, Name = "Duke", Seed = 4, RegionID = 1, Year = 2016 },
                new Team { TeamID = 14, Name = "California", Seed = 4, RegionID = 1, Year = 2016 },
                new Team { TeamID = 15, Name = "Kentucky", Seed = 4, RegionID = 1, Year = 2016 },
                new Team { TeamID = 16, Name = "IowaState", Seed = 4, RegionID = 1, Year = 2016 },
                new Team { TeamID = 17, Name = "Indiana", Seed = 5, RegionID = 1, Year = 2016 },
                new Team { TeamID = 18, Name = "Purdue", Seed = 5, RegionID = 1, Year = 2016 },
                new Team { TeamID = 19, Name = "Maryland", Seed = 5, RegionID = 1, Year = 2016 },
                new Team { TeamID = 20, Name = "Baylor", Seed = 5, RegionID = 1, Year = 2016 },
                new Team { TeamID = 21, Name = "Texas", Seed = 6, RegionID = 1, Year = 2016 },
                new Team { TeamID = 22, Name = "NotreDame", Seed = 6, RegionID = 1, Year = 2016 },
                new Team { TeamID = 23, Name = "Arizona", Seed = 6, RegionID = 1, Year = 2016 },
                new Team { TeamID = 24, Name = "SetonHall", Seed = 6, RegionID = 1, Year = 2016 },
                new Team { TeamID = 25, Name = "Wisconsin", Seed = 7, RegionID = 1, Year = 2016 },
                new Team { TeamID = 26, Name = "Dayton", Seed = 7, RegionID = 1, Year = 2016 },
                new Team { TeamID = 27, Name = "Iowa", Seed = 7, RegionID = 1, Year = 2016 },
                new Team { TeamID = 28, Name = "OregonState", Seed = 7, RegionID = 1, Year = 2016 },
                new Team { TeamID = 29, Name = "TexasTech", Seed = 8, RegionID = 1, Year = 2016 },
                new Team { TeamID = 30, Name = "Colorado", Seed = 8, RegionID = 1, Year = 2016 },
                new Team { TeamID = 31, Name = "USC", Seed = 8, RegionID = 1, Year = 2016 },
                new Team { TeamID = 32, Name = "SaintJosephs", Seed = 8, RegionID = 1, Year = 2016 },
                new Team { TeamID = 33, Name = "Providence", Seed = 9, RegionID = 1, Year = 2016 },
                new Team { TeamID = 34, Name = "Butler", Seed = 9, RegionID = 1, Year = 2016 },
                new Team { TeamID = 35, Name = "Cincinnati", Seed = 9, RegionID = 1, Year = 2016 },
                new Team { TeamID = 36, Name = "UConn", Seed = 9, RegionID = 1, Year = 2016 },
                new Team { TeamID = 37, Name = "Pittsburgh", Seed = 10, RegionID = 1, Year = 2016 },
                new Team { TeamID = 38, Name = "Temple", Seed = 10, RegionID = 1, Year = 2016 },
                new Team { TeamID = 39, Name = "Syracuse", Seed = 10, RegionID = 1, Year = 2016 },
                new Team { TeamID = 40, Name = "VCU", Seed = 10, RegionID = 1, Year = 2016 },
                new Team { TeamID = 41, Name = "Vanderbilt", Seed = 11, RegionID = 1, Year = 2016 },
                new Team { TeamID = 42, Name = "Michigan", Seed = 11, RegionID = 1, Year = 2016 },
                new Team { TeamID = 43, Name = "WichitaState", Seed = 11, RegionID = 1, Year = 2016 },
                new Team { TeamID = 44, Name = "Gonzaga", Seed = 11, RegionID = 1, Year = 2016 },
                new Team { TeamID = 45, Name = "Tulsa", Seed = 12, RegionID = 1, Year = 2016 },
                new Team { TeamID = 46, Name = "NorthernIowa", Seed = 12, RegionID = 1, Year = 2016 },
                new Team { TeamID = 47, Name = "Chattanooga", Seed = 12, RegionID = 1, Year = 2016 },
                new Team { TeamID = 48, Name = "LittleRock", Seed = 12, RegionID = 1, Year = 2016 },
                new Team { TeamID = 49, Name = "Yale", Seed = 13, RegionID = 1, Year = 2016 },
                new Team { TeamID = 50, Name = "SouthDakotaState", Seed = 13, RegionID = 1, Year = 2016 },
                new Team { TeamID = 51, Name = "UNC-Wilmington", Seed = 13, RegionID = 1, Year = 2016 },
                new Team { TeamID = 52, Name = "Hawaii", Seed = 13, RegionID = 1, Year = 2016 },
                new Team { TeamID = 53, Name = "StonyBrook", Seed = 14, RegionID = 1, Year = 2016 },
                new Team { TeamID = 54, Name = "Iona", Seed = 14, RegionID = 1, Year = 2016 },
                new Team { TeamID = 55, Name = "GreenBay", Seed = 14, RegionID = 1, Year = 2016 },
                new Team { TeamID = 56, Name = "Buffalo", Seed = 14, RegionID = 1, Year = 2016 },
                new Team { TeamID = 57, Name = "FresnoState", Seed = 15, RegionID = 1, Year = 2016 },
                new Team { TeamID = 58, Name = "StephenF.Austin", Seed = 15, RegionID = 1, Year = 2016 },
                new Team { TeamID = 59, Name = "MiddleTennessee", Seed = 15, RegionID = 1, Year = 2016 },
                new Team { TeamID = 60, Name = "CSUBakersfield", Seed = 15, RegionID = 1, Year = 2016 },
                new Team { TeamID = 61, Name = "UNC-Asheville", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 62, Name = "WeberState", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 63, Name = "AustinPeay", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 64, Name = "Hampton", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 65, Name = "FGCU", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 66, Name = "FairleighDickinson", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 67, Name = "Southern", Seed = 16, RegionID = 1, Year = 2016 },
                new Team { TeamID = 68, Name = "HolyCross", Seed = 16, RegionID = 1, Year = 2016 }
            );

            context.SaveChanges();

            context.Entries.AddOrUpdate(
            e => e.EntryID,
                new Entry
                {
                    EntryID = 1,
                    PlayerID = 1,
                    Year = 2016,
                    Teams = context.Teams.Where(x => x.Name == "Indiana"
                                                  || x.Name == "Kansas"
                                                  || x.Name == "VCU"
                                                  || x.Name == "MichiganState"
                                                  || x.Name == "FresnoState").ToList()
                },
                new Entry
                {
                    EntryID = 2,
                    PlayerID = 1,
                    Year = 2016,
                    Teams = context.Teams.Where(x => x.Name == "Wisconsin"
                        || x.Name == "Duke"
                        || x.Name == "Virginia"
                        || x.Name == "FGCU"
                        || x.Name == "California").ToList()
                }
            );

            context.SaveChanges();

        }
    }
}
