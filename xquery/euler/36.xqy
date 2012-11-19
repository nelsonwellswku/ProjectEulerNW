xquery version "1.0-ml";

import module namespace nwnu = "http://nelsonwells.net/xquery/number-utils"
at "/lib/number-utils.xqy";

let $seq :=
  for $i in (1 to 100) 
    if(nwnu:is-palindrome($i)) 
    then
      
    else
      ()