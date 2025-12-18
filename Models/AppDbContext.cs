using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Uppfinaren_1._0.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }
    public DbSet<Inventor> Inventors { get; set; }
    public DbSet<Artwork> Artworks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Inventor>().HasData(
            new Inventor(
            1,
            "Dr. Eggman",
            "A brilliant but evil scientist known for his robotic creations and relentless pursuit of world domination.",
            "/img/inventors/Eggman.png",
            "DrEggman@evilrobotics.com",
            "555-1234",
            "123 Robot Lane, Tech City",
            "N/A"
        ), 
        new Inventor(
            2,
            "Dr. Robotnick",
            "A brilliant but evil scientist known for his robotic creations and relentless pursuit of world domination.",
            "/img/inventors/Robotnik.png",
            "DrRobotnick@evilrobotics.com",
            "555-1234",
            "123 Robot Lane, Tech City",
            "N/A"
        ),
        new Inventor(
            3,
            "Dr. Nefarious",
            "Dr. Nefarious is a mad scientist who acts largely out of vengeance and hatred, particularly for his nemeses. In his various quests for galactic domination, he has manipulated many into doing his bidding, but his personal assistant Lawrence has been his main ally throughout. Dr. Nefarious has a disdain for organic life-forms, which he refers to as 'squishies', though he sometimes allies with and deploys them depending on his needs.",
            "/img/inventors/DrNefarious.png",
            "NefariousGenius@ihatesquishies.com",
            "1234-123",
            "Solana Galaxy, Biobliterator",
            "Secret robot chat, nickname: 'Very smart and attractive robot1885'"
        )
        );
        modelBuilder.Entity<Artwork>().HasData(
            new Artwork(
            1,
            1,
            "Egg Emperor",
            "Dr Eggman",
            @"A gigantic mech empowered by a chaos emerald. Perfect for elimination of annoying blue hedgehogs.",
            "/img/artworks/eggEmperor.png",
            "Robots"
        ),
        new Artwork(
            2,
            1,
            "Egg Mobile",
            "Dr Eggman",
            @"The Egg Mobile (エッグモービル Eggu Mōbiru?), alternatively spelled as the Eggmobile,
            The Egg Mobile is known for its versatility, being capable of travelling across all types of terrain and being armed with several weapons of its own. Its most enduring feature is its compatibility with Eggman's various vehicles and creations and serves as well as an escape pod when they are inevitably defeated by Sonic and his allies.",
            "/img/artworks/eggMobile.png",
            "Vehicles"
        ),
        new Artwork(
            3,
            2,
            "Doomsday Machine",
            "Dr Robotnick",
            "large and advanced machine that served as the control center of the Doomsday Project, whose aim was to destroy all life on Mobius.",
            "/img/artworks/doomsdayMachine.png",
            "Evil bases"
        ),
        new Artwork(
            4,
            1,
            "Egg Albatross",
            "Dr Eggman",
            @"A massive airborne battle fortress and the final form of Eggman's sky-based ambitions. 
            The Egg Albatross combines overwhelming firepower, rotating weapon modules, and an 
            almost insulting confidence in its own invincibility. Designed to dominate the skies 
            and crush resistance from above, it ultimately proves that no amount of armor can 
            protect against gravity, teamwork, and a very fast blue hedgehog.",
            "/img/artworks/eggAlbatross.png",
            "Robots"
        ),
        new Artwork(
            5,
            3,
            "Biobliterator",
            "Dr. Nefarious",
            @"A colossal superweapon built by Dr. Nefarious with one charming hobby: turning every organic lifeform into a robot.
            In its ominous spherical form, it fires a transmogrification beam that converts targets instantly, then recharges between planetary attacks like it’s doing cardio.
            When subtlety inevitably fails, it can unfold into a towering robot mode armed with missiles and plasma blasts. The ultimate statement piece for any anti-organic campaign.",
            "/img/artworks/biobliterator.png",
            "Weapons"
        ),
        new Artwork(
            6,
            3,
            "VX-99",
            "Dr. Nefarious",
            @"An elite combat robot engineered for televised destruction and maximum viewer engagement.
            The VX-99 is fast, heavily armed, and annoyingly resilient, designed to hunt targets across
            hostile arenas while shrugging off punishment like it’s part of the script. Built for
            Ratchet’s gladiatorial nightmare, it represents Nefarious’ belief that violence is better
            when it’s broadcast, sponsored, and deeply unfair.",
            "/img/artworks/vx99.png",
            "Robots"
            ),
        new Artwork(
            7,
            3,
            "Hypersonic Brainwave Scrambler",
            "Dr. Nefarious",
            @"A delightfully unethical mind control device engineered to hijack free will on a massive scale.
            The Hypersonic Brainwave Scrambler emits powerful sonic frequencies that override rational thought,
            forcing victims to obey commands whether they like it or not. Designed for planetary domination
            with minimal physical effort, it perfectly reflects Dr. Nefarious’ core philosophy: why conquer
            through force when you can reprogram everyone’s brain instead?",
            "/img/artworks/HBS.png",
            "Gadgets"
            ),
        new Artwork(
            8,
            3,
            "Party Crasher",
            "Dr. Nefarious",
            @"A brutally cheerful close range weapon disguised as a celebration.
            The Party Crasher fires a wide spread of explosive projectiles that turn
            crowded rooms into instant chaos, shredding enemies before they can
            reconsider their life choices. Loud, excessive, and deeply unsubtle,
            it proves that Dr. Nefarious believes every fight deserves confetti, shockwaves,
            and emotional damage.",
            "/img/artworks/partyCrasher.png",
            "Weapons"
            ),
        new Artwork(
            9,
            1,
            "Death Egg Robot",
            "Dr. Eggman",
            @"A towering combat mech built as the ultimate expression of Eggman’s obsession with size, power,
            and dramatic final battles. The Death Egg Robot is armed with crushing fists, heavy artillery,
            and enough raw presence to blot out common sense. Deployed when subtle plans inevitably fail,
            it exists to remind everyone that Eggman always saves his biggest tantrum for last.",
            "/img/artworks/deathEggRobot.png",
            "Robots"
            ),
        new Artwork(
            10,
            1,
            "Egg Dragoon",
            "Dr. Eggman",
            @"A heavily armed combat mech engineered specifically to counter super fast hedgehogs and ruin their day.
            The Egg Dragoon combines jet propulsion, energy shields, missile barrages, and a cockpit designed for
            dramatic speeches mid battle. Deployed as a last resort, it represents Eggman at his most focused,
            most furious, and most unwilling to accept defeat like an adult.",
            "/img/artworks/eggDragoon.png",
            "Robots"
            ),
        new Artwork(
            11,
            2,
            "SWATbots",
            "Dr. Robotnik",
            @"Mass produced robotic enforcers built to patrol, suppress, and generally ruin everyone’s day.
            SWATbots are fast, heavily armed, and programmed with unwavering loyalty to Eggman’s empire.
            Deployed in squads, they excel at crowd control, base defense, and proving that efficiency
            is scarier than genius when it comes in bulk.",
            "/img/artworks/SWATbots.png",
            "Robots"
            ),
        new Artwork(
            12,
            2,
            "Stupidity Ray",
            "Dr. Robotnik",
            @"A deceptively simple ray weapon designed to dramatically lower the intelligence of its targets.
            The Stupidity Ray doesn’t destroy cities or flatten armies; it does something far worse by
            making its victims incapable of coherent thought, strategy, or basic problem solving.
            Created as a psychological weapon, it perfectly captures Eggman’s belief that the easiest
            enemy to defeat is one who can no longer think.",
            "/img/artworks/stupidityRay.png",
            "Gadgets"
            )

        );
    }
}
