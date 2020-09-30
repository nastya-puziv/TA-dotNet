Feature: Check if the secondary article names match the required titles

@mytag

Scenario: Check if the secondary article names match the required titles
Given BBC News 
When Get text from the secondary articles
Then The names of the articles should be equal to the specific text