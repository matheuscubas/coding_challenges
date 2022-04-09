def kangaroo(x1, v1, x2, v2)
  
  loop do
    return 'NO' if x2 >x1 && v2 > v1
    return 'NO' if x1 > x2 && v1 > v2
    return 'NO' if x1 > x2 && v1 == v2
    return 'NO' if x2 > x1 && v2 == v1
    
    x1 += v1
    x2 += v2
    
    return 'YES' if x1 == x2
  end
end