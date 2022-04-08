def countApplesAndOranges(s, t, a, b, apples, oranges) 
  
  fallen_apples = apples.map do |apple|
    apple += a
  end
  
  fallen_oranges = oranges.map do |oranges|
    oranges += b
  end
  
  puts fallen_apples.select { |apple| apple.between?(s,t) }.count
  puts fallen_oranges.select { |orange| orange.between?(s,t) }.count
end