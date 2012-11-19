xquery version "1.0-ml";

import module namespace nwnu = "http://nelsonwells.net/xquery/number-utils"
at "/lib/number-utils.xqy";

for $i in 100 to 999
  for $j in 100 to 999
    let $res := $i * $j
    order by $res
    return if(nwnu:is-palindrome(nwnu:number-to-seq($i * $j))) 
	  then $res
      else ()