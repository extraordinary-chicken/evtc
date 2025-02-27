using System;
using GW2Scratch.EVTCAnalytics.GameData;
using GW2Scratch.EVTCAnalytics.Model.Agents;
using NUnit.Framework;

namespace GW2Scratch.EVTCAnalytics.Tests.GameData
{
	public class CharactersTests
	{
		[Test]
		public void AllProfessionsHaveAHeartOfThornsEliteSpecialization()
		{
			foreach (var profession in Characters.Professions)
			{
				EliteSpecialization specialization = EliteSpecialization.None;
				Assert.DoesNotThrow(() => specialization = Characters.GetHeartOfThornsEliteSpecialization(profession));
				Assert.AreNotEqual(EliteSpecialization.None, specialization);
			}
		}

		[Test]
		public void AllProfessionsHaveAPathOfFireEliteSpecialization()
		{
			foreach (var profession in Characters.Professions)
			{
				EliteSpecialization specialization = EliteSpecialization.None;
				Assert.DoesNotThrow(() => specialization = Characters.GetPathOfFireEliteSpecialization(profession));
				Assert.AreNotEqual(EliteSpecialization.None, specialization);
			}
		}
		
		[Test]
		public void AllProfessionsHaveAnEndOfDragonsEliteSpecialization()
		{
			foreach (var profession in Characters.Professions)
			{
				EliteSpecialization specialization = EliteSpecialization.None;
				Assert.DoesNotThrow(() => specialization = Characters.GetEndOfDragonsEliteSpecialization(profession));
				Assert.AreNotEqual(EliteSpecialization.None, specialization);
			}
		}

		[Test]
		public void AllEliteSpecializationsHaveABaseProfession()
		{
			foreach (EliteSpecialization eliteSpecialization in Enum.GetValues(typeof(EliteSpecialization)))
			{
				if (eliteSpecialization == EliteSpecialization.None)
				{
					continue;
				}

				Profession profession = Profession.None;
				Assert.DoesNotThrow(() => profession = Characters.GetProfession(eliteSpecialization));
				Assert.AreNotEqual(EliteSpecialization.None, profession);
			}
		}
	}
}