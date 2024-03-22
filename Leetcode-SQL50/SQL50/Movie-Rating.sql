/*
Table: Movies
+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| movie_id      | int     |
| title         | varchar |
+---------------+---------+
movie_id is the primary key for this table.
title is the name of the movie.
 
Table: Users
+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| user_id       | int     |
| name          | varchar |
+---------------+---------+
user_id is the primary key for this table.
 
Table: MovieRating
+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| movie_id      | int     |
| user_id       | int     |
| rating        | int     |
| created_at    | date    |
+---------------+---------+
(movie_id, user_id) is the primary key for this table.
This table contains the rating of a movie by a user in their review.
created_at is the user's review date. 
 
Write an SQL query to:

Find the name of the user who has rated the greatest number of movies. In case of a tie, return the lexicographically smaller user name.
Find the movie name with the highest average rating in February 2020. In case of a tie, return the lexicographically smaller movie name.
*/

WITH UserName AS (
  SELECT u.name, u.user_id, COUNT(mr.movie_id) userCount
  FROM Users u JOIN MovieRating mr
  ON u.user_id = mr.user_id
  JOIN Movies m
  ON mr.movie_id = m.movie_id
  GROUP BY u.user_id, u.name
),
MovieTitle AS (
  SELECT m.title, AVG(rating * 1.0) ratingAvg
  FROM MovieRating mr INNER JOIN Movies m
  ON mr.movie_id = m.movie_id
  WHERE MONTH(mr.created_at) = MONTH('2020-02-01') AND YEAR(mr.created_at) = YEAR('2020-02-01')
  GROUP BY m.title
)

SELECT UserName2.name as results
FROM (
  SELECT TOP 1 *
  FROM UserName
  ORDER BY userCount DESC, name
) UserName2
UNION ALL
SELECT MovieTitle2.title as results
FROM (
  SELECT TOP 1 * 
  FROM MovieTitle
  ORDER BY ratingAvg DESC, title
) MovieTitle2
