# Use the official InfluxDB image as the base image.
FROM grafana/loki:2.9.4


# Expose default Loki port
EXPOSE 3100

# Copy custom configuration file (if needed)
# COPY loki-config.yaml /etc/loki/config.yaml

# Command to run Loki (uncomment below if using a custom config)
 CMD ["/usr/bin/loki", "-config.file=/etc/loki/config.yaml"]

