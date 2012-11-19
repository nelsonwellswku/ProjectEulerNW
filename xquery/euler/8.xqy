xquery version "1.0-ml";

import module namespace nwnu = "http://nelsonwells.net/xquery/number-utils"
at "/lib/number-utils.xqy";

let $seq := nwnu:number-to-seq(

return for $i in $seq
  nwnu:multiply($i, $seq[$i + 1], $seq[$i + 2])