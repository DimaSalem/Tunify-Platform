# Tunify Platform

Tunify Platform is a web application designed to manage and interact with music-related data. It integrates various entities such as users, subscriptions, playlists, songs, artists, albums, and playlist songs into a cohesive system.

ERD Diagram
![ERD](./Tunify.png)

Entity Relationships

User: Represents an individual using the platform.
Subscription: Links users to their subscription plans.
Playlist: Contains collections of songs created by users.
Song: Individual music tracks.
Artist: Represents musicians or groups.
Album: Groups of songs released together by artists.
PlaylistSongs: Links songs to playlists, allowing multiple songs in each playlist.
Each entity is related through foreign keys and navigational properties as depicted in the ERD, ensuring proper data management and relationships.