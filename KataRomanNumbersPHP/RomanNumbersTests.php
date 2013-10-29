<?php
include "RomanNumbers.php";

class RomanNumbersTests extends PHPUnit_Framework_TestCase
{
    public function setUp()
    {
        // your code here
    }

    public function tearDown()
    {
        // your code here
    }

    /**
     * @covers Class::Method
     */
    public function testCovertToRoman1ReturnI()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(1);
		$this->assertEquals($result, "I");
    }
    
    public function testCovertToRoman2ReturnII()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(2);
        $this->assertEquals($result, "II");
    }

    public function testCovertToRoman5ReturnV()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(5);
        $this->assertEquals($result, "V");
    }

    public function testCovertToRoman7ReturnVII()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(7);
        $this->assertEquals($result, "VII");
    }

    public function testCovertToRoman10ReturnX()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(10);
        $this->assertEquals($result, "X");
    }

    public function testCovertToRoman15ReturnXV()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(15);
        $this->assertEquals($result, "XV");
    }

    public function testCovertToRoman38ReturnXXXVIII()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(38);
        $this->assertEquals($result, "XXXVIII");
    }

    public function testCovertToRoman50ReturnL()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(50);
        $this->assertEquals($result, "L");
    }

    public function testCovertToRoman9ReturnIX()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(9);
        $this->assertEquals($result, "IX");
    }

    public function testCovertToRoman39ReturnXXXIX()
    {
        $romanConverter = new RomanNumbers();
        $result = $romanConverter->ConvertToRoman(39);
        $this->assertEquals($result, "XXXIX");
    }
}

?>