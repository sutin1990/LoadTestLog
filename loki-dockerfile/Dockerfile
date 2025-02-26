# Use the official InfluxDB image as the base image.
FROM grafana/loki:2.9.4

# Set the working directory
WORKDIR /etc/loki

# Copy the custom Loki config file
COPY ./config/loki-config.yaml /etc/loki/loki-config.yaml

# Expose Loki's default ports
EXPOSE 3100

# Start Loki with the custom config file
CMD ["/usr/bin/loki", "-config.file=/etc/loki/loki-config.yaml"]

