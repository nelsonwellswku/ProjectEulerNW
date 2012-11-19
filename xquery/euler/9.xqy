xquery version "1.0-ml";

(: TODO: Time expired on script execution when running... :)

for $i in (1 to 1000)
  for $j in (1 to 1000)
    for $k in (1 to 1000)
      return 
        if(math:pow($i, 2) + math:pow($j, 2) eq math:pow($k, 2) )
        then 
          if($i + $j + $k eq 1000)
          then
            ($i, $j, $k)
          else
            ()
        else
          ()