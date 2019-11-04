using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class IOrderItemTests
    {
        #region Entrees
        [Fact]
        public void BrontowurstShouldHaveCorrectDescription()
        {
            Brontowurst dr = new Brontowurst();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void DinoNuggetsShouldHaveCorrectDescription()
        {
            DinoNuggets dr = new DinoNuggets();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void PrehistoricPBJShouldHaveCorrectDescription()
        {
            PrehistoricPBJ dr = new PrehistoricPBJ();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void PterodactylWingsShouldHaveCorrectDescription()
        {
            PterodactylWings dr = new PterodactylWings();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectDescription()
        {
            SteakosaurusBurger dr = new SteakosaurusBurger();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void TRexKingBurgerShouldHaveCorrectDescription()
        {
            TRexKingBurger dr = new TRexKingBurger();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void VelociWrapShouldHaveCorrectDescription()
        {
            VelociWrap dr = new VelociWrap();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void BrontowurstShouldHaveCorrectSpecial()
        {
            Brontowurst dr = new Brontowurst();
            dr.HoldBun();
            dr.HoldOnion();
            dr.HoldPeppers();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Whole Wheat Bun", item); },
                item => { Assert.Equal("Hold Peppers", item); },
                item => { Assert.Equal("Hold Onion", item); }
                );
        }
        [Fact]
        public void DinoNuggetsShouldHaveCorrectSpecial()
        {
            DinoNuggets dr = new DinoNuggets();
            dr.AddNugget();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("1 Extra Nuggets", item); }
                );
        }
        [Fact]
        public void PrehistoricPBJShouldHaveCorrectSpecial()
        {
            PrehistoricPBJ dr = new PrehistoricPBJ();
            dr.HoldPeanutButter();
            dr.HoldJelly();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Peanut Butter", item); },
                item => { Assert.Equal("Hold Jelly", item); }
                );
        }
        [Fact]
        public void PterodactylWingsShouldHaveCorrectSpecial()
        {
            PterodactylWings dr = new PterodactylWings();
        }
        [Fact]
        public void SteakosaurusBurgerShouldHaveCorrectSpecial()
        {
            SteakosaurusBurger dr = new SteakosaurusBurger();
            dr.HoldBun();
            dr.HoldKetchup();
            dr.HoldMustard();
            dr.HoldPickle();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Whole Wheat Bun", item); },
                item => { Assert.Equal("Hold Ketchup", item); },
                item => { Assert.Equal("Hold Mustard", item); },
                item => { Assert.Equal("Hold Pickle", item); }
                );
        }
        [Fact]
        public void TRexKingBurgerShouldHaveCorrectSpecial()
        {
            TRexKingBurger dr = new TRexKingBurger();
            dr.HoldBun();
            dr.HoldMayo();
            dr.HoldKetchup();
            dr.HoldLettuce();
            dr.HoldMustard();
            dr.HoldOnion();
            dr.HoldPickle();
            dr.HoldTomato();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Whole Wheat Bun", item); },
                item => { Assert.Equal("Hold Mayo", item); },
                item => { Assert.Equal("Hold Ketchup", item); },
                item => { Assert.Equal("Hold Lettuce", item); },
                item => { Assert.Equal("Hold Mustard", item); },
                item => { Assert.Equal("Hold Onion", item); },
                item => { Assert.Equal("Hold Pickle", item); },
                item => { Assert.Equal("Hold Tomato", item); }
                );
        }
        [Fact]
        public void VelociWrapShouldHaveCorrectSpecial()
        {
            VelociWrap dr = new VelociWrap();
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
        public void TriceritotsShouldHaveCorrectDescription()
        {
            Triceritots dr = new Triceritots();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void MezzorellaSticksShouldHaveCorrectDescription()
        {
            MezzorellaSticks dr = new MezzorellaSticks();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void MeteorMacAndCheeseShouldHaveCorrectDescription()
        {
            MeteorMacAndCheese dr = new MeteorMacAndCheese();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void FriceritopsShouldHaveCorrectDescription()
        {
            Fryceritops dr = new Fryceritops();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void TriceritotsShouldHaveCorrectSpecial()
        {
            Triceritots dr = new Triceritots();
        }
        [Fact]
        public void MezzorellaSicksShouldHaveCorrectSpecial()
        {
            MezzorellaSticks dr = new MezzorellaSticks();
        }
        [Fact]
        public void MeteorMacAndCheeseShouldHaveCorrectSpecial()
        {
            MeteorMacAndCheese dr = new MeteorMacAndCheese();
        }
        [Fact]
        public void FriceritopsShouldHaveCorrectSpecial()
        {
            Fryceritops dr = new Fryceritops();
        }
        #endregion

        #region Drinks
        [Fact]
        public void WaterShouldHaveCorrectDescription()
        {
            Water dr = new Water();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void JurrasicJavaShouldHaveCorrectDescription()
        {
            JurassicJava dr = new JurassicJava();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void SodasaurusShouldHaveCorrectDescription()
        {
            Sodasaurus dr = new Sodasaurus();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void TyrannoteaShouldHaveCorrectDescription()
        {
            Tyrannotea dr = new Tyrannotea();
            Assert.Equal(dr.Description, dr.ToString());
        }
        [Fact]
        public void WaterShouldHaveCorrectSpecial()
        {
            Water dr = new Water();
            dr.AddLemon();
            dr.HoldIce();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Lemon", item); },
                item => { Assert.Equal("Hold Ice", item); }
                );
        }
        [Fact]
        public void JurrasicJavaShouldHaveCorrectSpecial()
        {
            JurassicJava dr = new JurassicJava();
            dr.AddIce();
            dr.LeaveRoomForCream();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Add Ice", item); },
                item => { Assert.Equal("Leave Room For Cream", item); }
                );
        }
        [Fact]
        public void SodasaurusShouldHaveCorrectSpecial()
        {
            Sodasaurus dr = new Sodasaurus();
            dr.HoldIce();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Hold Ice", item); }
                );
        }
        [Fact]
        public void TyrannoteaShouldHaveCorrectSpecial()
        {
            Tyrannotea dr = new Tyrannotea();
            dr.AddLemon();
            dr.HoldIce();
            Assert.Collection<string>(dr.Special,
                item => { Assert.Equal("Lemon", item); },
                item => { Assert.Equal("Hold Ice", item); }
                );
        }
        #endregion


    }
}
