using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class INotifyPropertyChangedTests
    {
        #region Entrees
        [Fact]
        public void BrontowurstShouldUpdateComponents()
        {
            Brontowurst dr = new Brontowurst();
            Assert.Equal(dr.Description, dr.ToString());
            //Assert.PropertyChanged( );
        }
        [Fact]
        public void DinoNuggetsShouldUpdateComponents()
        {
            DinoNuggets dr = new DinoNuggets();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void PrehistoricPBJShouldUpdateComponents()
        {
            PrehistoricPBJ dr = new PrehistoricPBJ();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void PterodactylWingsShouldUpdateComponents()
        {
            PterodactylWings dr = new PterodactylWings();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void SteakosaurusBurgerShouldUpdateComponents()
        {
            SteakosaurusBurger dr = new SteakosaurusBurger();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void TRexKingBurgerShouldUpdateComponents()
        {
            TRexKingBurger dr = new TRexKingBurger();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void VelociWrapShouldUpdateComponents()
        {
            VelociWrap dr = new VelociWrap();
            Assert.Equal(dr.Description, dr.ToString());
            dr.HoldDressing();
            dr.HoldLettuce();
            dr.HoldCheese();

            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Ceasar Dressing", item); },
                item => { Assert.Equal("Hold Romaine Lettuce", item); },
                item => { Assert.Equal("Hold Parmesan Cheese", item); }
                );
        }
        #endregion

        #region Sides
        [Fact]
        public void TriceritotsShouldUpdateComponents()
        {
            Triceritots dr = new Triceritots();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void MezzorellaSticksShouldUpdateComponents()
        {
            MezzorellaSticks dr = new MezzorellaSticks();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void MeteorMacAndCheeseShouldUpdateComponents()
        {
            MeteorMacAndCheese dr = new MeteorMacAndCheese();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void FriceritopsShouldUpdateComponents()
        {
            Fryceritops dr = new Fryceritops();
            Assert.Equal(dr.Description, dr.ToString());
        }
        #endregion

        #region Drinks
        [Fact]
        public void WaterShouldUpdateComponents()
        {
            Water dr = new Water();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void JurrasicJavaShouldUpdateComponents()
        {
            JurassicJava dr = new JurassicJava();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void SodasaurusShouldUpdateComponents()
        {
            Sodasaurus dr = new Sodasaurus();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void TyrannoteaShouldUpdateComponents()
        {
            Tyrannotea dr = new Tyrannotea();
            Assert.Equal(dr.Description, dr.ToString());
        }        
        #endregion
    }
}
