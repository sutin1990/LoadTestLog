# Use the official InfluxDB image as the base image.
FROM grafana/loki:2.9.4

# Expose the correct port
EXPOSE 3100

# Ensure Loki runs with correct arguments
CMD ["-config.file=/etc/loki/local-config.yaml"]