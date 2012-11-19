xquery version "1.0-ml";

module namespace nwnu = "http://nelsonwells.net/xquery/number-utils";

declare function nwnu:number-to-seq($num as xs:integer) 
as xs:integer* {
  if($num gt 9) then
    (
	  nwnu:number-to-seq(xs:integer(math:floor($num div 10))),
	  xs:integer(math:floor($num mod 10))
	)
  else 
    $num
};

declare function nwnu:seq-to-number($seq as xs:integer*)
as xs:integer {

  let $res :=
    fn:string-join(
      for $i in $seq
        return xs:string($i),
      ("")
    )
        
  return xs:integer($res)
   
};

declare function nwnu:is-palindrome($seq as xs:integer*)
as xs:boolean {

  if (fn:empty($seq))
    then fn:true()
  else if ($seq[1] ne $seq[fn:last()])
    then fn:false()
  else
    nwnu:is-palindrome($seq[2 to fn:last() - 1])

};

declare function nwnu:multiply($seq as xs:integer*) 
as xs:integer {

  if(fn:count($seq) eq 1) then
    $seq[1] 
  else
    nwnu:multiply($seq[1 to fn:last() - 1]) * $seq[fn:last()]

};

declare function nwnu:is-divisible($num as xs:integer, $by as xs:integer)
as xs:boolean {

  $num mod $by eq 0

};

(: TODO
declare function nwnu:convert-base($from as xs:integer, $to as $xs:integer) 
as xs:integer {
  if($from gt $to)
    then for
}
:)