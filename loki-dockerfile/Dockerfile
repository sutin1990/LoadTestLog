# Use the official Loki image
FROM grafana/loki:latest

# Copy your custom Loki config file into the container
COPY /loki-config.yaml /etc/loki/config.yaml

# Set the default command to start Loki with the config file
CMD [ "-config.file=/etc/loki/config.yaml" ]
