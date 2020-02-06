using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VideoExpertSystem;

namespace VideoExpertSystems.UnitTests
{
    public class RuleRepositoryTest
    {
        [Test]
        public void RuleRepository_AddQuestion_IsTrue()
        {
            var ruleRepo = new FactRepository();

            Assert.DoesNotThrow(() => ruleRepo.AddFact(new Fact("", "")));
        }

        [Test]
        public void FactEnumerator_HasCurrentFact_IsTrue()
        {
            Fact fact1 = new Fact("1", "1");
            List<Fact> factList = new List<Fact>() { fact1 };

            var enumerator = new FactRepository.FactEnumerator(factList);

            Assert.DoesNotThrow(() => enumerator.MoveNext());
        }

        [Test]
        public void FactEnumerator_HasNextFact_IsTrue()
        {
            Fact fact1 = new Fact("1", "1");
            Fact fact2 = new Fact("2", "2");
            List<Fact> factList = new List<Fact>() { fact1, fact2 };

            var enumerator = new FactRepository.FactEnumerator(factList);

            enumerator.MoveNext();
            Assert.DoesNotThrow(() => enumerator.MoveNext());
        }
    }
}
