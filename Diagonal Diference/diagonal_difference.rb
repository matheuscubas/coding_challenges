def diagonalDifference(arr)
  
  primary_diagonal_sum = 0
  secondary_diagonal_sum = 0
  
  arr.each_with_index do |row, i|
    primary_diagonal_sum += row[i]
    secondary_diagonal_sum += row.reverse[i]
  end
  
  puts (primary_diagonal_sum - secondary_diagonal_sum).abs
end

arr = [[11,2,4],[4,5,6],[10,8,-12]]

diagonalDifference(arr)

#=>15