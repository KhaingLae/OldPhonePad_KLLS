using OldPhonePad;

namespace OldPhonePad_KLLS.UnitTests
{
    public class OldPhonePadTests
    {
        [Theory]
        [InlineData("33#", "E")] //1 word input
        [InlineData("227*#", "B")] //1 word and 1 delete
        [InlineData("4433555 555666#", "HELLO")] //5 words input
        [InlineData("8 88777444666*664#", "TURING")] // 6 words and 1 delete
        [InlineData(null, "Null Input")] //null input
        [InlineData("", "")] //no iput
        [InlineData("    ", "")] //space iput
        [InlineData("4666 666306 66677766444664#", "GOOD MORNING")] //sentence input
        [InlineData("444333*11609244484446*6640*0333666777099966688#", "I'M WAITING FOR YOU")] //sentence with two deletes
        [InlineData("99999*999337777#", "YES")] //input with over 3 numbers for 9
        [InlineData("4447777777666 660777766633389277733#", "IRON SOFTWARE")] //input with over 4 numbers for 7
        [InlineData("000554424446640000055523305552330777766633#", " KHAING LAE LAE SOE")] //input with multiple spaces
        [InlineData("#", "")] //#only input
        [InlineData("*#", "")] //delete and #input
        [InlineData(" *#", "")] //space, delete and #input

        public void OldPhonePad_MultipleInputTests(string input, string expectedOutput)
        {
            string result = OldPhonePadFunctions.OldPhonePad(input);
            Assert.Equal(expectedOutput, result);
        }
    }
}