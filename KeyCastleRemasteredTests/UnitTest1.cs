using Domain;
using Domain.Enum;
using Domain.Hero;
using KeyCastleRemastered.MonsterFactory;

namespace KeyCastleRemasteredTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatePlayer_Given_Paladin_Should_ReturnNewPaladin()
        {
            var result = HeroFactory.CreatePlayer("Mark", PlayerClass.Paladin, PlayerRace.Human);

            Assert.IsTrue(Enum.GetName(result.PlayerClass) == Enum.GetName(PlayerClass.Paladin));

        }

        [Test]
        public void CreatePlayer_Given_Warrior_Should_ReturnNewWarrior()
        {
            var result = HeroFactory.CreatePlayer("Dwayne", PlayerClass.Warrior, PlayerRace.Human);

            Assert.IsTrue(Enum.GetName(result.PlayerClass) == Enum.GetName(PlayerClass.Warrior));
        }

        [Test]
        public void CreatePlayer_Given_Wizard_Should_ReturnNewWarrior()
        {
            var result = HeroFactory.CreatePlayer("Dwayne", PlayerClass.Wizard, PlayerRace.Human);

            Assert.IsTrue(Enum.GetName(result.PlayerClass) == Enum.GetName(PlayerClass.Wizard));
        }


        [Test]
        public void GenerateMonster_Given_Dragon_ShouldReturnNewDragon()
        {
            var result = MonsterFactory.CreateMonster(MonsterType.Dragon);

            Assert.That(Enum.GetName(result.MonsterType), Is.EqualTo(Enum.GetName(MonsterType.Dragon)));

        }

        [Test]
        public void GenerateMonster_Given_Zombie_ShouldReturnNewZombie()
        {
            var result = MonsterFactory.CreateMonster(MonsterType.Zombie);

            Assert.That(Enum.GetName(result.MonsterType), Is.EqualTo(Enum.GetName(MonsterType.Zombie)));

        }

        [Test]
        public void GenerateMonster_Given_Skeleton_ShouldReturnNewSkeleton()
        {
            var result = MonsterFactory.CreateMonster(MonsterType.Skeleton);

            Assert.That(Enum.GetName(result.MonsterType), Is.EqualTo(Enum.GetName(MonsterType.Skeleton)));

        }

    }
}