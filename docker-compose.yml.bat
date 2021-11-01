version: "4"
services:
  selenium-hub:
    image: selenium/hub:4.0.0
    container_name: selenium-hub
    ports:
      - "4444:4444"

  chrome:
    image: selenium/node-chrome:4.0.0
    volumes:
      - /dev/shm:/dev/shm    
    container_name: chrome
    depends_on:
      - selenium-hub
    environment:
      - HUB_HOST=selenium-hub
      - HUB_PORT=4444
      - NODE_MAX_INSTANCES=4
      - NODE_MAX_SESSION=4
    ports:
      - "6900:5900"     
      
  firefox:
    image: selenium/node-firefox:4.0.0
    volumes:
      - /dev/shm:/dev/shm
    depends_on:
      - selenium-hub
    environment:
      - HUB_HOST=selenium-hub
      - HUB_PORT=4444
      - NODE_MAX_INSTANCES=4
      - NODE_MAX_SESSION=4
    ports:
      - "6901:5900"

  edge:
    image: selenium/node-edge:4.0.0
    volumes:
      - /dev/shm:/dev/shm
    depends_on:
      - selenium-hub
    environment:
      - HUB_HOST=selenium-hub
      - HUB_PORT=4444
    ports:
      - "6902:5900"
    environment:
      - GRID_MAX_SESSION=4