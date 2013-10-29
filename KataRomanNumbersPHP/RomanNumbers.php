<?php
/**
* 
*/
class RomanNumbers
{
    function ConvertToRoman($arabic)
    {
        $return = "";
        if($arabic == 9)
            return "IX";

       if((($arabic % 50) >= 0) && ($arabic >=50))
        {
            $return = $return.'L';
            $arabic = $arabic - 50;
        }

        
        while((($arabic % 10) >= 0) && ($arabic >=10))
        {
            $return = $return.'X';
            $arabic = $arabic - 10;
        }

        if((($arabic % 9) >= 0) && ($arabic >=9))
        {
            $return = $return.'IX';
            $arabic = $arabic - 9;
        }

        if((($arabic % 5) >= 0) && ($arabic >=5))
        {
            $return = $return.'V';
            $arabic = $arabic - 5;
        }
        
        if((($arabic % 4) >= 0) && ($arabic >=4))
        {
            $return = $return.'IV';
            $arabic = $arabic - 4;
        }
        
        while($arabic > 0)
        {
            $return = $return."I";
            $arabic--;
        }
        
        return $return;

    }
}
?>