using System;

namespace Uppfinaren_1._0.Models.Data;

public class InMemoryArtworkRepository : IArtworkRepository
{
    private List<Artwork> _artworks = new List<Artwork>
    {
        new Artwork(
            1,
            "Egg Emperor",
            "Dr Eggman",
            @"A gigantic mech empowered by a chaos emerald. Perfect for elimination of annoying blue hedgehogs.",
            "/img/artworks/eggEmperor.png",
            "Egg Battle bots"
        ),
        new Artwork(
            2,
            "Egg Mobile",
            "Dr Eggman",
            @"The Egg Mobile (エッグモービル Eggu Mōbiru?), alternatively spelled as the Eggmobile,
            The Egg Mobile is known for its versatility, being capable of travelling across all types of terrain and being armed with several weapons of its own. Its most enduring feature is its compatibility with Eggman's various vehicles and creations and serves as well as an escape pod when they are inevitably defeated by Sonic and his allies.",
            "/img/artworks/eggMobile.png",
            "Egg vehicles"
        ),
        new Artwork(
            3,
            "Doomsday Machine",
            "Dr Robotnick",
            "large and advanced machine that served as the control center of the Doomsday Project, whose aim was to destroy all life on Mobius.",
            "/img/artworks/doomsdayMachine.png",
            "Evil hideouts"
        ),
        new Artwork(
            4,
            "Egg Albatross",
            "Dr Eggman",
            @"A massive airborne battle fortress and the final form of Eggman's sky-based ambitions. 
            The Egg Albatross combines overwhelming firepower, rotating weapon modules, and an 
            almost insulting confidence in its own invincibility. Designed to dominate the skies 
            and crush resistance from above, it ultimately proves that no amount of armor can 
            protect against gravity, teamwork, and a very fast blue hedgehog.",
            "/img/artworks/eggAlbatross.png",
            "Egg Battle bots"
        ),
        new Artwork(
            5,
            "Biobliterator",
            "Dr. Nefarious",
            @"A colossal superweapon built by Dr. Nefarious with one charming hobby: turning every organic lifeform into a robot.
            In its ominous spherical form, it fires a transmogrification beam that converts targets instantly, then recharges between planetary attacks like it’s doing cardio.
            When subtlety inevitably fails, it can unfold into a towering robot mode armed with missiles and plasma blasts. The ultimate statement piece for any anti-organic campaign.",
            "/img/artworks/biobliterator.png",
            "Nefarious superweapons"
        ), 
        new Artwork(
            6,
            "VX-99",
            "Dr. Nefarious",
            @"An elite combat robot engineered for televised destruction and maximum viewer engagement.
            The VX-99 is fast, heavily armed, and annoyingly resilient, designed to hunt targets across
            hostile arenas while shrugging off punishment like it’s part of the script. Built for
            Ratchet’s gladiatorial nightmare, it represents Nefarious’ belief that violence is better
            when it’s broadcast, sponsored, and deeply unfair.",
            "/img/artworks/vx99.png",
            "Combat robots"
        ),
        new Artwork(
            7,
            "Hypersonic Brainwave Scrambler",
            "Dr. Nefarious",
            @"A delightfully unethical mind control device engineered to hijack free will on a massive scale.
    The Hypersonic Brainwave Scrambler emits powerful sonic frequencies that override rational thought,
    forcing victims to obey commands whether they like it or not. Designed for planetary domination
    with minimal physical effort, it perfectly reflects Dr. Nefarious’ core philosophy: why conquer
    through force when you can reprogram everyone’s brain instead?",
            "/img/artworks/HBS.png",
            "Mind control devices"
        ),
        new Artwork(
            8,
            "Party Crasher",
            "Dr. Nefarious",
            @"A brutally cheerful close range weapon disguised as a celebration.
    The Party Crasher fires a wide spread of explosive projectiles that turn
    crowded rooms into instant chaos, shredding enemies before they can
    reconsider their life choices. Loud, excessive, and deeply unsubtle,
    it proves that Dr. Nefarious believes every fight deserves confetti, shockwaves,
    and emotional damage.",
            "img/artworks/partyCrasher.png",
            "Weapons"
        ),
        new Artwork(
            9,
            "Death Egg Robot",
            "Dr. Eggman",
            @"A towering combat mech built as the ultimate expression of Eggman’s obsession with size, power,
    and dramatic final battles. The Death Egg Robot is armed with crushing fists, heavy artillery,
    and enough raw presence to blot out common sense. Deployed when subtle plans inevitably fail,
    it exists to remind everyone that Eggman always saves his biggest tantrum for last.",
            "img/artworks/deathEggRobot.png",
            "Egg Battle bots"
        ),
        new Artwork(
            10,
            "Egg Dragoon",
            "Dr. Eggman",
            @"A heavily armed combat mech engineered specifically to counter super fast hedgehogs and ruin their day.
    The Egg Dragoon combines jet propulsion, energy shields, missile barrages, and a cockpit designed for
    dramatic speeches mid battle. Deployed as a last resort, it represents Eggman at his most focused,
    most furious, and most unwilling to accept defeat like an adult.",
            "img/artworks/eggDragoon.png",
            "Egg Battle bots"
        ), 
        new Artwork(
            11,
            "SWATbots",
            "Dr. Robotnik",
            @"Mass produced robotic enforcers built to patrol, suppress, and generally ruin everyone’s day.
    SWATbots are fast, heavily armed, and programmed with unwavering loyalty to Eggman’s empire.
    Deployed in squads, they excel at crowd control, base defense, and proving that efficiency
    is scarier than genius when it comes in bulk.",
            "img/artworks/SWATbots.png",
            "Security robots"
        ), 
        new Artwork(
            12,
            "Stupidity Ray",
            "Dr. Robotnik",
            @"A deceptively simple ray weapon designed to dramatically lower the intelligence of its targets.
    The Stupidity Ray doesn’t destroy cities or flatten armies; it does something far worse by
    making its victims incapable of coherent thought, strategy, or basic problem solving.
    Created as a psychological weapon, it perfectly captures Eggman’s belief that the easiest
    enemy to defeat is one who can no longer think.",
            "img/artworks/stupidityRay.png",
            "Mind control devices"
)
    };
    private int _nextId = 1;

    public void Add(Artwork artwork)
    {
        artwork.Id = _nextId++;
        _artworks.Add(artwork);
    }

    public Artwork? GetById(int id)
    {
        return _artworks.FirstOrDefault(a => a.Id == id);
    }

    public IEnumerable<Artwork> GetAll()
    {
        return _artworks;
    }

}
