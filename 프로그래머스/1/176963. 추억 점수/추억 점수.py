def solution(name, yearning, photo):
    check = len(name)
    result = []
    score=0
    for j in photo:
        for i in range(check):
            if name[i] in j:
                score += yearning[i]
        result.append(score)
        score = 0
    return result
        