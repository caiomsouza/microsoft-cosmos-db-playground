

```

SELECT VALUE COUNT(1) FROM tweets

SELECT * FROM tweets
where tweets.id = "1034752085504475136"

SELECT VALUE COUNT(1) FROM tweets
where tweets.lang = "es"

SELECT top 20 tweets.lang AS test
FROM tweets

SELECT VALUE COUNT(1) FROM tweets
where tweets.user.followers_count = 129

SELECT VALUE COUNT(1) FROM tweets
where tweets.user.followers_count BETWEEN 100000 AND 900000

SELECT * FROM tweets
where tweets.user.followers_count BETWEEN 100000 AND 900000



```
