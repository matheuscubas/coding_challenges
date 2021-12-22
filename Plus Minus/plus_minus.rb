
def plusMinus(arr)

  n = arr.size

  x = arr.count { |x| x.positive? } /n.to_f
  y = arr.count { |x| x.negative? } /n.to_f
  z = arr.count { |x| x.zero? } /n.to_f
  
  puts '%.6f' % x
  puts '%.6f' % y
  puts '%.6f' % z
end

n = 6

arr = [-4,3,-9,0,4,1]

plusMinus(arr)

=begin
0.500000
0.333333
0.166667
=end