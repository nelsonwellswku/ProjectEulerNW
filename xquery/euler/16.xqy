xquery version "1.0-ml";

import module namespace nwnu = "http://nelsonwells.net/xquery/number-utils"
at "/lib/number-utils.xqy";

nwnu:number-to-seq(xs:integer(math:pow(2, 50)))