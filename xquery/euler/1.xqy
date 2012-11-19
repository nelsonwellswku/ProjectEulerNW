fn:sum(
  (1 to 999)[
    . mod 3 eq 0 or
    . mod 5 eq 0
  ]
)